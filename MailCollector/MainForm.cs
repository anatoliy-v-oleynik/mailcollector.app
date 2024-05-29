using AE.Net.Mail;
using AE.Net.Mail.Imap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MailCollector
{
    public partial class MainForm : Form
    {
        public class MessageAction
        {
            public string Name;
            public string Destination;
        }

        struct MessageRowTag
        {
            public bool Processed;
            public MailMessage Message;
            public MessageAction[] Actions;
        }

        public ImapClient imap;
        public Lazy<MailMessage>[] messages;
        public SQLiteConnection connection;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowWaitDialog(Action codeToRun)
        {
            ManualResetEvent dialogLoadedFlag = new ManualResetEvent(false);

            // open the dialog on a new thread so that the dialog window gets
            // drawn. otherwise our long running code will run and the dialog
            // window never renders.
            (new Thread(() =>
            {
                Form waitDialog = new WaitForm()
                {
                    ControlBox = false,
                    FormBorderStyle = FormBorderStyle.None,
                    StartPosition = FormStartPosition.CenterParent,
                    Enabled = true
                };

                ProgressBar ScrollingBar = new ProgressBar()
                {
                    Style = ProgressBarStyle.Marquee,
                    Parent = waitDialog,
                    Dock = DockStyle.Fill,
                    Enabled = true
                };

                waitDialog.Load += new EventHandler((x, y) =>
                {
                    dialogLoadedFlag.Set();
                });

                waitDialog.Shown += new EventHandler((x, y) =>
                {
                    Thread thread = new Thread(() =>
                    {
                        codeToRun();
                        this.Invoke((MethodInvoker)(() => waitDialog.Close()));
                    });

                    thread.Priority = ThreadPriority.Lowest;
                    thread.Start();
                });

                this.Invoke((MethodInvoker)(() => waitDialog.ShowDialog(this)));
            })).Start();

            while (dialogLoadedFlag.WaitOne(100, true) == false)
                Application.DoEvents(); // note: this will block the main thread once the wait dialog shows
        }

        private void AddTemplate(DataGridViewRow row = null)
        {
            TemplateForm form = new TemplateForm();
            if (row != null)
            {
                form.senderSearchModeComboBox.SelectedIndex = 1;
                form.senderTextBox.Text = (string)row.Cells["messageSenderColumn"].Value;
                form.subjectSearchModeComboBox.SelectedIndex = 1;
                form.subjectTextBox.Text = (string)row.Cells["messageSubjectColumn"].Value;

            }

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                SQLiteTransaction transaction = connection.BeginTransaction();

                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO templates ([enable], [sender_mode],[sender_text],[subject_mode],[subject_text],[body_mode],[body_text],[attachment_mode],[attachment_text],[action],[destination]) VALUES (1, @sender_mode,@sender_text,@subject_mode,@subject_text,@body_mode,@body_text,@attachment_mode,@attachment_text,@action,@destination)";
                    command.Parameters.AddWithValue("@sender_mode", form.senderSearchModeComboBox.Text);
                    command.Parameters.AddWithValue("@sender_text", form.senderTextBox.Text);
                    command.Parameters.AddWithValue("@subject_mode", form.subjectSearchModeComboBox.Text);
                    command.Parameters.AddWithValue("@subject_text", form.subjectTextBox.Text);
                    command.Parameters.AddWithValue("@body_mode", form.bodySearchModeComboBox.Text);
                    command.Parameters.AddWithValue("@body_text", form.bodyTextBox.Text);
                    command.Parameters.AddWithValue("@attachment_mode", form.attachmentSearchModeComboBox.Text);
                    command.Parameters.AddWithValue("@attachment_text", form.attachmentTextBox.Text);
                    command.Parameters.AddWithValue("@action", form.actionComboBox.Text);
                    command.Parameters.AddWithValue("@destination", form.destinationTextBox.Text);
                    command.ExecuteNonQuery();
                }

                templatesDataGridView.Rows.Add(new object[] { connection.LastInsertRowId, true, form.senderSearchModeComboBox.Text, form.senderTextBox.Text, form.subjectSearchModeComboBox.Text, form.subjectTextBox.Text, form.bodySearchModeComboBox.Text, form.bodyTextBox.Text, form.attachmentSearchModeComboBox.Text, form.attachmentTextBox.Text, form.actionComboBox.Text, form.destinationTextBox.Text });

                transaction.Commit();
            }
        }

        private void EditTemplate(DataGridViewRow row = null)
        {
            TemplateForm form = new TemplateForm();
            if (row != null)
            {
                form.Tag = row.Cells["templateUidColumn"].Value;
                form.senderSearchModeComboBox.Text = (string)row.Cells["templateSenderSearchModeColumn"].Value;
                form.senderTextBox.Text = (string)row.Cells["templateSenderSearchTextColumn"].Value;
                form.subjectSearchModeComboBox.Text = (string)row.Cells["templateSubjectSearchModeColumn"].Value;
                form.subjectTextBox.Text = (string)row.Cells["templateSubjectSearchTextColumn"].Value;
                form.bodySearchModeComboBox.Text = (string)row.Cells["templateBodySearchModeColumn"].Value;
                form.bodyTextBox.Text = (string)row.Cells["templateBodySearchTextColumn"].Value;
                form.attachmentSearchModeComboBox.Text = (string)row.Cells["templateAttachmentSearchModeColumn"].Value;
                form.attachmentTextBox.Text = (string)row.Cells["templateAttachmentSearchTextColumn"].Value;
                form.actionComboBox.Text = (string)row.Cells["templateActionColumn"].Value;
                form.destinationTextBox.Text = (string)row.Cells["templateDestinationColumn"].Value;
            }

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                SQLiteTransaction transaction = connection.BeginTransaction();

                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE templates SET [sender_mode] = @sender_mode, [sender_text] = @sender_text, [subject_mode] = @subject_mode, [subject_text] = @subject_text, [body_mode] = @body_mode, [body_text] = @body_text, [attachment_mode] = @attachment_mode, [attachment_text] = @attachment_text, [action] = @action, [destination] = @destination WHERE [uid] = @uid";
                    command.Parameters.AddWithValue("@uid", form.Tag);
                    command.Parameters.AddWithValue("@sender_mode", form.senderSearchModeComboBox.Text);
                    command.Parameters.AddWithValue("@sender_text", form.senderTextBox.Text);
                    command.Parameters.AddWithValue("@subject_mode", form.subjectSearchModeComboBox.Text);
                    command.Parameters.AddWithValue("@subject_text", form.subjectTextBox.Text);
                    command.Parameters.AddWithValue("@body_mode", form.bodySearchModeComboBox.Text);
                    command.Parameters.AddWithValue("@body_text", form.bodyTextBox.Text);
                    command.Parameters.AddWithValue("@attachment_mode", form.attachmentSearchModeComboBox.Text);
                    command.Parameters.AddWithValue("@attachment_text", form.attachmentTextBox.Text);
                    command.Parameters.AddWithValue("@action", form.actionComboBox.Text);
                    command.Parameters.AddWithValue("@destination", form.destinationTextBox.Text);
                    command.ExecuteNonQuery();
                }

                row.Cells["templateSenderSearchModeColumn"].Value = form.senderSearchModeComboBox.Text;
                row.Cells["templateSenderSearchTextColumn"].Value = form.senderTextBox.Text;
                row.Cells["templateSubjectSearchModeColumn"].Value = form.subjectSearchModeComboBox.Text;
                row.Cells["templateSubjectSearchTextColumn"].Value = form.subjectTextBox.Text;
                row.Cells["templateBodySearchModeColumn"].Value = form.bodySearchModeComboBox.Text;
                row.Cells["templateBodySearchTextColumn"].Value = form.bodyTextBox.Text;
                row.Cells["templateAttachmentSearchModeColumn"].Value = form.attachmentSearchModeComboBox.Text;
                row.Cells["templateAttachmentSearchTextColumn"].Value = form.attachmentTextBox.Text;
                row.Cells["templateActionColumn"].Value = form.actionComboBox.Text;
                row.Cells["templateDestinationColumn"].Value = form.destinationTextBox.Text;

                transaction.Commit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.connection = new SQLiteConnection("Data Source=data.db");
            connection.Open();

            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM templates";
                SQLiteDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    
                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);
                    this.templatesDataGridView.Rows.Add(data);
                }
            }

            this.messagesDataGridView.Columns["messageProcessedColumn"].DefaultCellStyle.NullValue = null;
            this.messagesDataGridView.Columns["messageMarkIconColumn"].DefaultCellStyle.NullValue = null;
            this.messagesDataGridView.Columns["messageAttachmentIconColumn"].DefaultCellStyle.NullValue = null;

            this.messageViewerTabControl.Appearance = TabAppearance.FlatButtons;
            this.messageViewerTabControl.ItemSize = new Size(0, 1);
            this.messageViewerTabControl.SizeMode = TabSizeMode.Fixed;

            this.Width = Properties.Settings.Default.MainFormWidth;
            this.Height = Properties.Settings.Default.MainFormHeight;
            this.WindowState = Properties.Settings.Default.MainFormWindowState;
            this.messagesSplitContainer.SplitterDistance = Properties.Settings.Default.MessageViewerSplitterDistance;

            imap = new AE.Net.Mail.ImapClient(serverUrlTextBox.Text, serverLoginTextBox.Text, serverPasswordTextBox.Text, AE.Net.Mail.AuthMethods.Login, Convert.ToInt32(serverPortTextBox.Text), serverUseSSLCheckBox.Checked);
            Mailbox[] mailbox = imap.ListMailboxes("", "*");
            foreach (Mailbox mailboxItem in mailbox)
            {
                mailboxesComboBox.Items.Add(mailboxItem.Name.Replace("INBOX", "Входящие"));
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.MainFormWidth = this.Width;
            Properties.Settings.Default.MainFormHeight = this.Height;
            Properties.Settings.Default.MainFormWindowState = this.WindowState;
            Properties.Settings.Default.MessageViewerSplitterDistance = messagesSplitContainer.SplitterDistance;
            Properties.Settings.Default.Save();
        }

        private void Imap_NewMessage(object sender, AE.Net.Mail.Imap.MessageEventArgs e)
        {
            MailMessage msg = imap.GetMessage(e.MessageCount - 1);
            imap.AddFlags(Flags.Seen, new MailMessage[1] { msg });

            this.Invoke(new Action(() =>
            {
                this.messagesDataGridView.Rows.Add(new string[2] { msg.Date.ToString(), msg.From.ToString() });
            }));
        }

        private void manualCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            lastDateTimePicker.Enabled = manualDatetimeCheckBox.Checked;
            mailboxesComboBox.Enabled = manualDatetimeCheckBox.Checked;
        }

        private void autoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void selectSaveFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                saveFolderPathTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void actionShowDetailButton_Click(object sender, EventArgs e)
        {
            actionsSplitContainer.Panel2Collapsed = !actionsSplitContainer.Panel2Collapsed;
        }

        private void messageViewShowButton_Click(object sender, EventArgs e)
        {
            messagesSplitContainer.Panel2Collapsed = !messagesSplitContainer.Panel2Collapsed;
        }

        private void messagesDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (messagesDataGridView.Rows[e.RowIndex].Tag != null)
            {
                MailMessage msg = ((MessageRowTag)messagesDataGridView.Rows[e.RowIndex].Tag).Message;

                if (msg.ContentType == "text/html")
                {
                    richTextBox1.Text = "";
                    webViewer.DocumentText = "";
                    webViewer.Refresh();
                    webViewer.Document.Write(msg.Body);
                    messageViewerTabControl.SelectedIndex = 1;
                }
                else
                {
                    richTextBox1.Text = msg.Body;
                    webViewer.DocumentText = "";
                    webViewer.Refresh();
                    messageViewerTabControl.SelectedIndex = 0;
                }

                attachmentFileListView.Clear();

                foreach (Attachment attachment in msg.Attachments)
                {
                    attachmentFileListView.Items.Add(attachment.Filename);
                }
            }
        }

        private void receiveMailButton_Click(object sender, EventArgs e)
        {
            
            this.progressBar.Visible = true;
            this.receiveMailButton.Enabled = false;
            this.messageAutoReceiveCheckBox.Enabled = false;

            this.manualDatetimeCheckBox.Enabled = false;
            this.lastDateTimePicker.Enabled = false;
            this.mailboxesComboBox.Enabled = false;

            imap.SelectMailbox(mailboxesComboBox.Text.Replace("Входящие", "INBOX"));
            messagesReceiveBackgroundWorker.RunWorkerAsync();
        }

        private void ProccessMessage(DataGridViewRow row)
        {
            row.Cells["messageProcessedColumn"].Value = Properties.Resources.icons8_circle_blue_8;
        }

         private void messagesDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    DataGridViewRow row = messagesDataGridView.Rows[e.RowIndex];
                    MailMessage msg = ((MessageRowTag)row.Tag).Message;

                    if (!this.messagesDataGridView[e.ColumnIndex, e.RowIndex].Selected)
                    {
                        this.messagesDataGridView.ClearSelection();
                        this.messagesDataGridView.CurrentCell = messagesDataGridView[e.ColumnIndex, e.RowIndex];
                    }

                    Rectangle cdr = messagesDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                    this.messageProccessToolStripMenuItem.Enabled = row.Cells["messageMarkIconColumn"].Value != null;
                    this.messageSaveAttachmentToolStripMenuItem.Enabled = msg.Attachments.Count > 0;

                    this.messageSetMarkByTemplatesToolStripMenuItem.Enabled = row.Cells["messageMarkIconColumn"].Value == null;
                    this.messageSetMarkToolStripMenuItem.Enabled = row.Cells["messageMarkIconColumn"].Value == null;
                    this.messageClearMarkToolStripMenuItem.Enabled = row.Cells["messageMarkIconColumn"].Value != null;

                    this.messageMarkSaveAttachmentsToolStripMenuItem.Enabled = msg.Attachments.Count > 0;
                    this.messagesContextMenuStrip.Show(messagesDataGridView, cdr.X + e.X, cdr.Y + e.Y);
                }
            }
        }

        private void templatesDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    if (!templatesDataGridView[e.ColumnIndex, e.RowIndex].Selected)
                    {
                        templatesDataGridView.ClearSelection();
                        templatesDataGridView.CurrentCell = templatesDataGridView[e.ColumnIndex, e.RowIndex];
                    }

                    Rectangle cdr = templatesDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                    deleteTemplateToolStripMenuItem.Enabled = true;
                    templatesContextMenuStrip.Show(templatesDataGridView, cdr.X + e.X, cdr.Y + e.Y);
                }
            }
        }

        private void templatesDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditTemplate(templatesDataGridView.Rows[e.RowIndex]);
        }

        private bool MatchCondition(string mode, string value, string pattern)
        {
            bool result = true;

            switch (mode.ToLower())
            {
                case "содержит":
                    result = Regex.Match(value, pattern).Success;
                    break;
                case "не содержит":
                    result = !Regex.Match(value, pattern).Success;
                    break;
                case "соответствует":
                    result = Regex.Match(value, "^" + pattern + "$/gi").Success;
                    break;
                case "начинается":
                    result = Regex.Match(value, "^" + pattern + "/gi").Success;
                    break;
                case "заканчивается":
                    result = Regex.Match(value, "" + pattern + "$/gi").Success;
                    break;
                case "регулярное выражение":
                    result = Regex.Match(value, pattern).Success;
                    break;
            }

            return result;
        }

        void MarkByTemplates(DataGridViewRow row, DataGridViewRowCollection templates)
        {
            MailMessage msg = ((MessageRowTag)row.Tag).Message;

            Console.WriteLine("ОБРАБОТКА ПИСЬМА: " + (string)row.Cells["messageSenderColumn"].Value);

            foreach (DataGridViewRow template in templates)
            {
                bool senderSuccess = MatchCondition((string)template.Cells["templateSenderSearchModeColumn"].Value, (string)row.Cells["messageSenderColumn"].Value, (string)template.Cells["templateSenderSearchTextColumn"].Value);
                bool subjectSuccess = MatchCondition((string)template.Cells["templateSubjectSearchModeColumn"].Value, (string)row.Cells["messageSubjectColumn"].Value, (string)template.Cells["templateSubjectSearchTextColumn"].Value);
                bool bodySuccess = MatchCondition((string)template.Cells["templateBodySearchModeColumn"].Value, msg.Body, (string)template.Cells["templateBodySearchTextColumn"].Value);
                bool attachmentSuccess = MatchCondition((string)template.Cells["templateAttachmentSearchModeColumn"].Value, (string)template.Cells["templateAttachmentSearchTextColumn"].Value, "\\*\\.\\*");
                 

                if (!attachmentSuccess)
                {
                    string[] fileMasks = (template.Cells["templateAttachmentSearchTextColumn"].Value as string).Split(';');
                    if (fileMasks.Length > 0)
                    {
                        Console.WriteLine("Есть другие маски отбора файлов");

                        Attachment[] savedFiles = new Attachment[] { };

                        foreach (Attachment attachment in msg.Attachments)
                        {
                            if (Array.Exists<string>(fileMasks, (element) =>
                            {
                                string fileMaskExtension = element.Substring(element.LastIndexOf("."));
                                return Path.GetExtension(attachment.Filename).Equals(fileMaskExtension, StringComparison.OrdinalIgnoreCase);
                            }))
                            {
                                Console.WriteLine("Подходит для сохранения: {0}", attachment.Filename);

                                savedFiles.Append(attachment);
                            };
                        }

                        attachmentSuccess = savedFiles.Length > 0;
                    }
                }

                bool success = senderSuccess && subjectSuccess && bodySuccess && attachmentSuccess;

                if (success)
                {

                    //actions.Add((template.Cells["templateActionColumn"].Value as string), (template.Cells["templateDestinationColumn"].Value as string));

                    switch ((template.Cells["templateActionColumn"].Value as string).ToLower())
                    {
                        case "сохранить вложение":
                            row.Cells["messageMarkIconColumn"].ToolTipText = (template.Cells["templateDestinationColumn"].Value as string);
                            row.Cells["messageMarkIconColumn"].Value = Properties.Resources.icons8_save_navy_18;
                            break;
                        case "переслать письмо":
                            row.Cells["messageMarkIconColumn"].ToolTipText = (template.Cells["templateDestinationColumn"].Value as string);
                            row.Cells["messageMarkIconColumn"].Value = Properties.Resources.icons8_forward_arrow_18;
                            break;
                        case "пометить флажком":
                            row.Cells["messageMarkIconColumn"].Value = Properties.Resources.icons8_bookmark_red_18;
                            break;
                        case "пометить как информация":
                            row.Cells["messageMarkIconColumn"].Value = Properties.Resources.icons8_info_blue_18;
                            break;
                        case "пометить на удаление":
                            row.Cells["messageMarkIconColumn"].ToolTipText = "";
                            row.Cells["messageMarkIconColumn"].Value = Properties.Resources.icons8_remove_stone_18;
                            row.DefaultCellStyle.ForeColor = Color.Gray;
                            row.DefaultCellStyle.Font = new Font(row.InheritedStyle.Font, FontStyle.Strikeout);
                            break;
                        case "пометить как спам":
                            row.Cells["messageMarkIconColumn"].ToolTipText = "";
                            row.Cells["messageMarkIconColumn"].Value = Properties.Resources.icons8_spam_gray_18;
                            row.DefaultCellStyle.ForeColor = Color.Gray;
                            break;
                    }
                }
            }
        }

        private void messagesContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "createTemplateToolStripMenuItem":
                    foreach (DataGridViewRow row in this.messagesDataGridView.SelectedRows)
                    {
                        AddTemplate(row);
                    }
                    break;
                case "messageSaveAttachmentToolStripMenuItem":
                    foreach (DataGridViewRow row in this.messagesDataGridView.SelectedRows)
                    {
                        if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
                        {
                            MailMessage msg = ((MessageRowTag)row.Tag).Message;
                            foreach (Attachment a in msg.Attachments)
                            {
                                a.Save(this.folderBrowserDialog.SelectedPath + a.Filename);
                            }
                        }
                    }
                    break;
                case "messageProccessToolStripMenuItem":
                    foreach (DataGridViewRow row in this.messagesDataGridView.SelectedRows)
                    {
                        if (row.Cells["messageMarkIconColumn"].Value != null)
                        {
                            if (row.Cells["messageProcessedColumn"].Value == null)
                            {
                                ProccessMessage(row);
                            }
                            else if (MessageBox.Show(this, "Письмо уже обработано. Вы точно хотите его обработать повторно?", "Внимание!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                ProccessMessage(row);
                            }
                        }
                        else
                        {
                            MessageBox.Show(this, "Для того чтобы обработать письмо необходимо указать метку.", "Внимание!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    break;
                case "messageSetMarkByTemplatesToolStripMenuItem":

                    DataGridViewRowCollection templates = this.templatesDataGridView.Rows;

                    foreach (DataGridViewRow row in this.messagesDataGridView.SelectedRows)
                    {
                        MarkByTemplates(row, templates);
                    }
                    break;
                case "messageClearMarkToolStripMenuItem":
                    foreach (DataGridViewRow row in this.messagesDataGridView.SelectedRows)
                    {
                        if (row.Cells["messageProcessedColumn"].Value == null)
                        {
                            row.Cells["messageMarkIconColumn"].Value = null;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                            row.DefaultCellStyle.Font = new Font(row.InheritedStyle.Font, FontStyle.Regular);
                        }
                        else if (MessageBox.Show(this, "Письмо уже обработано. Вы точно хотите снять метку?", "Внимание!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            row.Cells["messageMarkIconColumn"].Value = null;
                            row.Cells["messageProcessedColumn"].Value = null;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                            row.DefaultCellStyle.Font = new Font(row.InheritedStyle.Font, FontStyle.Regular);
                        }
                    }
                    break;
            }
        }

        private void messageSetMarkToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (DataGridViewRow row in this.messagesDataGridView.SelectedRows)
            {
                row.Cells["messageMarkIconColumn"].ToolTipText = "";

                switch (e.ClickedItem.Name)
                {
                    case "messageMarkSaveAttachmentsToolStripMenuItem":
                        row.Cells["messageMarkIconColumn"].ToolTipText = folderBrowserDialog.SelectedPath;
                        row.Cells["messageMarkIconColumn"].Value = Properties.Resources.icons8_save_navy_18;
                        break;
                    case "messageMarkForwardToolStripMenuItem":
                        row.Cells["messageMarkIconColumn"].Value = Properties.Resources.icons8_forward_arrow_18;
                        break;
                    case "messageMarkBookmarkToolStripMenuItem":
                        row.Cells["messageMarkIconColumn"].Value = Properties.Resources.icons8_bookmark_18;
                        break;
                    case "messageMarkSpamToolStripMenuItem":
                        row.Cells["messageMarkIconColumn"].Value = Properties.Resources.icons8_spam_yello_18;
                        row.DefaultCellStyle.ForeColor = Color.Gray;
                        break;
                    case "messageMarkDeleteToolStripMenuItem":
                        row.Cells["messageMarkIconColumn"].Value = Properties.Resources.icons8_remove_stone_18;
                        row.DefaultCellStyle.ForeColor = Color.Gray;
                        row.DefaultCellStyle.Font = new Font(row.InheritedStyle.Font, FontStyle.Strikeout);
                        break;
                }
            }
        }

        private void templatesContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "addTemplateToolStripMenuItem":
                    AddTemplate();
                    break;
                case "deleteTemplateToolStripMenuItem":
                    foreach (DataGridViewRow row in this.templatesDataGridView.SelectedRows)
                    {
                        SQLiteCommand command = connection.CreateCommand();
                        command.CommandText = "DELETE FROM templates WHERE uid = @uid";
                        command.Parameters.AddWithValue("@uid", row.Cells["templateUidColumn"].Value);
                        command.ExecuteNonQuery();

                        this.templatesDataGridView.Rows.Remove(row);
                    }
                    break;
            }
        }

        private void templatesContextMenuStrip_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            addTemplateToolStripMenuItem.Enabled = true;
            deleteTemplateToolStripMenuItem.Enabled = false;
        }

        private void messagesReceiveBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            messages = imap.SearchMessages(SearchCondition.SentSince(lastDateTimePicker.Value));

            int counter = 0;
            int messagesCount = messages.Count();

            foreach (var m in messages)
            {
                ++counter;
                messagesReceiveBackgroundWorker.ReportProgress((int)((counter * 100) / messagesCount));

                if (m.Value.Date > lastDateTimePicker.Value)
                {

                    if (!this.IsDisposed)
                    {
                        this.Invoke((MethodInvoker)(() =>
                        {
                            string files = "";
                            foreach (Attachment attachment in m.Value.Attachments) files += attachment.Filename + "\r\n";

                            lastDateTimePicker.Value = m.Value.Date;

                            int row = this.messagesDataGridView.Rows.Add();
                            this.messagesDataGridView.Rows[row].Tag = new MessageRowTag { Processed = false, Message = m.Value, Actions = new MessageAction[] { } };

                            this.messagesDataGridView.Rows[row].Cells["messageDateColumn"].Value = m.Value.Date.ToString();
                            this.messagesDataGridView.Rows[row].Cells["messageSenderColumn"].Value = (m.Value.Sender != null) ? m.Value.Sender.ToString() : (m.Value.From != null ? m.Value.From.ToString() : m.Value.Headers["From"].Value);
                            this.messagesDataGridView.Rows[row].Cells["messageSubjectColumn"].Value = m.Value.Subject;

                            this.messagesDataGridView.Rows[row].Cells["messageAttachmentIconColumn"].Value = m.Value.Attachments.Count > 0 ? Properties.Resources.icons8_attach_18 : null;
                            this.messagesDataGridView.Rows[row].Cells["messageAttachmentIconColumn"].ToolTipText = files;

                            if (this.messageAutoMarkCheckBox.Checked)
                            {
                                MarkByTemplates(this.messagesDataGridView.Rows[row], this.templatesDataGridView.Rows);
                            }
                        }));
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private void messagesReceiveBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar.Value = e.ProgressPercentage;
        }

        private void messagesReceiveBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.progressBar.Visible = false;
            this.receiveMailButton.Enabled = true;
            this.messageAutoReceiveCheckBox.Enabled = true;
            this.manualDatetimeCheckBox.Enabled = true;
            this.lastDateTimePicker.Enabled = manualDatetimeCheckBox.Checked;
            this.mailboxesComboBox.Enabled = manualDatetimeCheckBox.Checked;
        }

        private void templatesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.templatesDataGridView.Columns[e.ColumnIndex].Name == "templateEnabledColumn")
            {
                DataGridViewCheckBoxCell cell = this.templatesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                cell.Value = !Convert.ToBoolean(cell.Value);

                SQLiteTransaction transaction = connection.BeginTransaction();

                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE templates SET [enable] = @enable WHERE [uid] = @uid";
                    command.Parameters.AddWithValue("@uid", this.templatesDataGridView.Rows[e.RowIndex].Cells["templateUidColumn"].Value);
                    command.Parameters.AddWithValue("@enable", cell.Value);
                    command.ExecuteNonQuery();
                }

                transaction.Commit();
            }
        }

        private void messagesDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void messagesDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void messageAutoReceiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            receiveMailButton.Enabled = !messageAutoReceiveCheckBox.Checked;
            manualDatetimeCheckBox.Enabled = !messageAutoReceiveCheckBox.Checked;
            lastDateTimePicker.Enabled = manualDatetimeCheckBox.Checked && !messageAutoReceiveCheckBox.Checked;
            mailboxesComboBox.Enabled = manualDatetimeCheckBox.Checked && !messageAutoReceiveCheckBox.Checked;

            imap.SelectMailbox(mailboxesComboBox.Text.Replace("Входящие", "INBOX"));

            if (messageAutoReceiveCheckBox.Checked)
            {
                imap.NewMessage += Imap_NewMessage;
            }
            else
            {
                imap.NewMessage -= Imap_NewMessage;
            }
        }

        private void updateMarkButton_Click(object sender, EventArgs e)
        {
            DataGridViewRowCollection templates = this.templatesDataGridView.Rows;

            foreach (DataGridViewRow row in this.messagesDataGridView.Rows)
            {
                MarkByTemplates(row, templates);
            }
        }
    }
}
