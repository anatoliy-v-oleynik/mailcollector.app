namespace MailCollector
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.messageAutoReceiveCheckBox = new System.Windows.Forms.CheckBox();
            this.messageAutoMarkCheckBox = new System.Windows.Forms.CheckBox();
            this.manualDatetimeCheckBox = new System.Windows.Forms.CheckBox();
            this.receiveMailButton = new System.Windows.Forms.Button();
            this.lastDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mailboxesComboBox = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.countStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.templatesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.messageSaveAttachmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageForwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.messageProccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.messageSetMarkByTemplatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageSetMarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageMarkSaveAttachmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageMarkForwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageMarkBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageMarkSpamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageMarkDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageClearMarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.messagesReceiveBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.messagesProccessBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.messagesTabPage = new System.Windows.Forms.TabPage();
            this.messagesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.messagesDataGridView = new System.Windows.Forms.DataGridView();
            this.messageProcessedColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.messageMarkIconColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.messageDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageSenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageSubjectColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageAttachmentIconColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.messageViewShowButton = new System.Windows.Forms.Button();
            this.messageViewerTabControl = new System.Windows.Forms.TabControl();
            this.textViewTabPage = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.webViewTabPage = new System.Windows.Forms.TabPage();
            this.webViewer = new System.Windows.Forms.WebBrowser();
            this.attachmentFileListView = new System.Windows.Forms.ListView();
            this.actionsTabPage = new System.Windows.Forms.TabPage();
            this.actionsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.templatesDataGridView = new System.Windows.Forms.DataGridView();
            this.templateUidColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templateEnabledColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.templateSenderSearchModeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templateSenderSearchTextColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templateSubjectSearchModeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templateSubjectSearchTextColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templateBodySearchModeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templateBodySearchTextColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templateAttachmentSearchModeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templateAttachmentSearchTextColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templateActionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templateDestinationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.actionShowDetailButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serverPasswordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serverLoginTextBox = new System.Windows.Forms.TextBox();
            this.serverUseSSLCheckBox = new System.Windows.Forms.CheckBox();
            this.serverPortTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serverUrlTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.saveFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.selectSaveFolderButton = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.updateMarkButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.templatesContextMenuStrip.SuspendLayout();
            this.messagesContextMenuStrip.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.messagesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messagesSplitContainer)).BeginInit();
            this.messagesSplitContainer.Panel1.SuspendLayout();
            this.messagesSplitContainer.Panel2.SuspendLayout();
            this.messagesSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messagesDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.messageViewerTabControl.SuspendLayout();
            this.textViewTabPage.SuspendLayout();
            this.webViewTabPage.SuspendLayout();
            this.actionsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionsSplitContainer)).BeginInit();
            this.actionsSplitContainer.Panel1.SuspendLayout();
            this.actionsSplitContainer.Panel2.SuspendLayout();
            this.actionsSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templatesDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.updateMarkButton);
            this.panel2.Controls.Add(this.messageAutoReceiveCheckBox);
            this.panel2.Controls.Add(this.messageAutoMarkCheckBox);
            this.panel2.Controls.Add(this.manualDatetimeCheckBox);
            this.panel2.Controls.Add(this.receiveMailButton);
            this.panel2.Controls.Add(this.lastDateTimePicker);
            this.panel2.Controls.Add(this.mailboxesComboBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(993, 57);
            this.panel2.TabIndex = 8;
            // 
            // messageAutoReceiveCheckBox
            // 
            this.messageAutoReceiveCheckBox.AutoSize = true;
            this.messageAutoReceiveCheckBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.messageAutoReceiveCheckBox.Location = new System.Drawing.Point(710, 10);
            this.messageAutoReceiveCheckBox.Name = "messageAutoReceiveCheckBox";
            this.messageAutoReceiveCheckBox.Size = new System.Drawing.Size(137, 37);
            this.messageAutoReceiveCheckBox.TabIndex = 19;
            this.messageAutoReceiveCheckBox.Text = "Автополучение писем";
            this.messageAutoReceiveCheckBox.UseVisualStyleBackColor = true;
            this.messageAutoReceiveCheckBox.CheckedChanged += new System.EventHandler(this.messageAutoReceiveCheckBox_CheckedChanged);
            // 
            // messageAutoMarkCheckBox
            // 
            this.messageAutoMarkCheckBox.AutoSize = true;
            this.messageAutoMarkCheckBox.Checked = global::MailCollector.Properties.Settings.Default.messageAutoMark;
            this.messageAutoMarkCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MailCollector.Properties.Settings.Default, "messageAutoMark", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.messageAutoMarkCheckBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.messageAutoMarkCheckBox.Location = new System.Drawing.Point(847, 10);
            this.messageAutoMarkCheckBox.Name = "messageAutoMarkCheckBox";
            this.messageAutoMarkCheckBox.Size = new System.Drawing.Size(136, 37);
            this.messageAutoMarkCheckBox.TabIndex = 18;
            this.messageAutoMarkCheckBox.Text = "Автоустановка меток";
            this.messageAutoMarkCheckBox.UseVisualStyleBackColor = true;
            // 
            // manualDatetimeCheckBox
            // 
            this.manualDatetimeCheckBox.AutoSize = true;
            this.manualDatetimeCheckBox.Location = new System.Drawing.Point(9, 23);
            this.manualDatetimeCheckBox.Name = "manualDatetimeCheckBox";
            this.manualDatetimeCheckBox.Size = new System.Drawing.Size(130, 17);
            this.manualDatetimeCheckBox.TabIndex = 15;
            this.manualDatetimeCheckBox.Text = "установить в ручную";
            this.manualDatetimeCheckBox.UseVisualStyleBackColor = true;
            this.manualDatetimeCheckBox.CheckedChanged += new System.EventHandler(this.manualCheckBox_CheckedChanged);
            // 
            // receiveMailButton
            // 
            this.receiveMailButton.Location = new System.Drawing.Point(483, 20);
            this.receiveMailButton.Name = "receiveMailButton";
            this.receiveMailButton.Size = new System.Drawing.Size(75, 23);
            this.receiveMailButton.TabIndex = 13;
            this.receiveMailButton.Text = "Получить";
            this.receiveMailButton.UseVisualStyleBackColor = true;
            this.receiveMailButton.Click += new System.EventHandler(this.receiveMailButton_Click);
            // 
            // lastDateTimePicker
            // 
            this.lastDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.lastDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::MailCollector.Properties.Settings.Default, "LastDateTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lastDateTimePicker.Enabled = false;
            this.lastDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lastDateTimePicker.Location = new System.Drawing.Point(151, 21);
            this.lastDateTimePicker.Name = "lastDateTimePicker";
            this.lastDateTimePicker.Size = new System.Drawing.Size(141, 20);
            this.lastDateTimePicker.TabIndex = 12;
            this.lastDateTimePicker.Value = global::MailCollector.Properties.Settings.Default.LastDateTime;
            // 
            // mailboxesComboBox
            // 
            this.mailboxesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MailCollector.Properties.Settings.Default, "SelectMailbox", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mailboxesComboBox.Enabled = false;
            this.mailboxesComboBox.FormattingEnabled = true;
            this.mailboxesComboBox.Location = new System.Drawing.Point(298, 21);
            this.mailboxesComboBox.Name = "mailboxesComboBox";
            this.mailboxesComboBox.Size = new System.Drawing.Size(174, 21);
            this.mailboxesComboBox.TabIndex = 11;
            this.mailboxesComboBox.Text = global::MailCollector.Properties.Settings.Default.SelectMailbox;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(993, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // countStatusLabel
            // 
            this.countStatusLabel.Name = "countStatusLabel";
            this.countStatusLabel.Size = new System.Drawing.Size(48, 17);
            this.countStatusLabel.Text = "кол-во:";
            // 
            // templatesContextMenuStrip
            // 
            this.templatesContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTemplateToolStripMenuItem,
            this.deleteTemplateToolStripMenuItem});
            this.templatesContextMenuStrip.Name = "actionsContextMenuStrip";
            this.templatesContextMenuStrip.Size = new System.Drawing.Size(127, 48);
            this.templatesContextMenuStrip.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.templatesContextMenuStrip_Closed);
            this.templatesContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.templatesContextMenuStrip_ItemClicked);
            // 
            // addTemplateToolStripMenuItem
            // 
            this.addTemplateToolStripMenuItem.Name = "addTemplateToolStripMenuItem";
            this.addTemplateToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.addTemplateToolStripMenuItem.Text = "Добавить";
            // 
            // deleteTemplateToolStripMenuItem
            // 
            this.deleteTemplateToolStripMenuItem.Enabled = false;
            this.deleteTemplateToolStripMenuItem.Name = "deleteTemplateToolStripMenuItem";
            this.deleteTemplateToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.deleteTemplateToolStripMenuItem.Text = "Удалить";
            // 
            // messagesContextMenuStrip
            // 
            this.messagesContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTemplateToolStripMenuItem,
            this.toolStripSeparator2,
            this.messageSaveAttachmentToolStripMenuItem,
            this.messageForwardToolStripMenuItem,
            this.toolStripSeparator3,
            this.messageProccessToolStripMenuItem,
            this.toolStripSeparator1,
            this.messageSetMarkByTemplatesToolStripMenuItem,
            this.messageSetMarkToolStripMenuItem,
            this.messageClearMarkToolStripMenuItem});
            this.messagesContextMenuStrip.Name = "messagesContextMenuStrip";
            this.messagesContextMenuStrip.Size = new System.Drawing.Size(247, 176);
            this.messagesContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.messagesContextMenuStrip_ItemClicked);
            // 
            // createTemplateToolStripMenuItem
            // 
            this.createTemplateToolStripMenuItem.Name = "createTemplateToolStripMenuItem";
            this.createTemplateToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.createTemplateToolStripMenuItem.Text = "Создать действие";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(243, 6);
            // 
            // messageSaveAttachmentToolStripMenuItem
            // 
            this.messageSaveAttachmentToolStripMenuItem.Name = "messageSaveAttachmentToolStripMenuItem";
            this.messageSaveAttachmentToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.messageSaveAttachmentToolStripMenuItem.Text = "Сохранить вложения";
            // 
            // messageForwardToolStripMenuItem
            // 
            this.messageForwardToolStripMenuItem.Name = "messageForwardToolStripMenuItem";
            this.messageForwardToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.messageForwardToolStripMenuItem.Text = "Переслать письмо";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(243, 6);
            // 
            // messageProccessToolStripMenuItem
            // 
            this.messageProccessToolStripMenuItem.Name = "messageProccessToolStripMenuItem";
            this.messageProccessToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.messageProccessToolStripMenuItem.Text = "Обработать";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(243, 6);
            // 
            // messageSetMarkByTemplatesToolStripMenuItem
            // 
            this.messageSetMarkByTemplatesToolStripMenuItem.Name = "messageSetMarkByTemplatesToolStripMenuItem";
            this.messageSetMarkByTemplatesToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.messageSetMarkByTemplatesToolStripMenuItem.Text = "Поставить метку по шаблонам";
            // 
            // messageSetMarkToolStripMenuItem
            // 
            this.messageSetMarkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageMarkSaveAttachmentsToolStripMenuItem,
            this.messageMarkForwardToolStripMenuItem,
            this.messageMarkBookmarkToolStripMenuItem,
            this.messageMarkSpamToolStripMenuItem,
            this.messageMarkDeleteToolStripMenuItem});
            this.messageSetMarkToolStripMenuItem.Name = "messageSetMarkToolStripMenuItem";
            this.messageSetMarkToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.messageSetMarkToolStripMenuItem.Text = "Поставить метку в ручную";
            this.messageSetMarkToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.messageSetMarkToolStripMenuItem_DropDownItemClicked);
            // 
            // messageMarkSaveAttachmentsToolStripMenuItem
            // 
            this.messageMarkSaveAttachmentsToolStripMenuItem.Name = "messageMarkSaveAttachmentsToolStripMenuItem";
            this.messageMarkSaveAttachmentsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.messageMarkSaveAttachmentsToolStripMenuItem.Text = "Сохранить вложения";
            // 
            // messageMarkForwardToolStripMenuItem
            // 
            this.messageMarkForwardToolStripMenuItem.Name = "messageMarkForwardToolStripMenuItem";
            this.messageMarkForwardToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.messageMarkForwardToolStripMenuItem.Text = "Переслать письмо";
            // 
            // messageMarkBookmarkToolStripMenuItem
            // 
            this.messageMarkBookmarkToolStripMenuItem.Name = "messageMarkBookmarkToolStripMenuItem";
            this.messageMarkBookmarkToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.messageMarkBookmarkToolStripMenuItem.Text = "Пометить флажком";
            // 
            // messageMarkSpamToolStripMenuItem
            // 
            this.messageMarkSpamToolStripMenuItem.Name = "messageMarkSpamToolStripMenuItem";
            this.messageMarkSpamToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.messageMarkSpamToolStripMenuItem.Text = "Пометить как спам";
            // 
            // messageMarkDeleteToolStripMenuItem
            // 
            this.messageMarkDeleteToolStripMenuItem.Name = "messageMarkDeleteToolStripMenuItem";
            this.messageMarkDeleteToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.messageMarkDeleteToolStripMenuItem.Text = "Удалить письмо";
            // 
            // messageClearMarkToolStripMenuItem
            // 
            this.messageClearMarkToolStripMenuItem.Name = "messageClearMarkToolStripMenuItem";
            this.messageClearMarkToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.messageClearMarkToolStripMenuItem.Text = "Убрать метку";
            // 
            // messagesReceiveBackgroundWorker
            // 
            this.messagesReceiveBackgroundWorker.WorkerReportsProgress = true;
            this.messagesReceiveBackgroundWorker.WorkerSupportsCancellation = true;
            this.messagesReceiveBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.messagesReceiveBackgroundWorker_DoWork);
            this.messagesReceiveBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.messagesReceiveBackgroundWorker_ProgressChanged);
            this.messagesReceiveBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.messagesReceiveBackgroundWorker_RunWorkerCompleted);
            // 
            // messagesProccessBackgroundWorker
            // 
            this.messagesProccessBackgroundWorker.WorkerReportsProgress = true;
            this.messagesProccessBackgroundWorker.WorkerSupportsCancellation = true;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.Location = new System.Drawing.Point(0, 57);
            this.progressBar.Name = "progressBar";
            this.progressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar.Size = new System.Drawing.Size(993, 4);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 19;
            this.progressBar.Visible = false;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.messagesTabPage);
            this.mainTabControl.Controls.Add(this.actionsTabPage);
            this.mainTabControl.Controls.Add(this.settingsTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 61);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(993, 436);
            this.mainTabControl.TabIndex = 20;
            // 
            // messagesTabPage
            // 
            this.messagesTabPage.Controls.Add(this.messagesSplitContainer);
            this.messagesTabPage.Location = new System.Drawing.Point(4, 22);
            this.messagesTabPage.Name = "messagesTabPage";
            this.messagesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.messagesTabPage.Size = new System.Drawing.Size(985, 410);
            this.messagesTabPage.TabIndex = 0;
            this.messagesTabPage.Text = "Письма";
            this.messagesTabPage.UseVisualStyleBackColor = true;
            // 
            // messagesSplitContainer
            // 
            this.messagesSplitContainer.BackColor = System.Drawing.SystemColors.Window;
            this.messagesSplitContainer.DataBindings.Add(new System.Windows.Forms.Binding("Panel2Collapsed", global::MailCollector.Properties.Settings.Default, "MessageViewerPannelCollapsed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.messagesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.messagesSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.messagesSplitContainer.Name = "messagesSplitContainer";
            this.messagesSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // messagesSplitContainer.Panel1
            // 
            this.messagesSplitContainer.Panel1.Controls.Add(this.messagesDataGridView);
            this.messagesSplitContainer.Panel1.Controls.Add(this.panel3);
            // 
            // messagesSplitContainer.Panel2
            // 
            this.messagesSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.messagesSplitContainer.Panel2.Controls.Add(this.messageViewerTabControl);
            this.messagesSplitContainer.Panel2.Controls.Add(this.attachmentFileListView);
            this.messagesSplitContainer.Panel2Collapsed = global::MailCollector.Properties.Settings.Default.MessageViewerPannelCollapsed;
            this.messagesSplitContainer.Size = new System.Drawing.Size(979, 404);
            this.messagesSplitContainer.SplitterDistance = 232;
            this.messagesSplitContainer.SplitterWidth = 5;
            this.messagesSplitContainer.TabIndex = 19;
            // 
            // messagesDataGridView
            // 
            this.messagesDataGridView.AllowUserToAddRows = false;
            this.messagesDataGridView.AllowUserToDeleteRows = false;
            this.messagesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.messagesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.messagesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.messagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.messageProcessedColumn,
            this.messageMarkIconColumn,
            this.messageDateColumn,
            this.messageSenderColumn,
            this.messageSubjectColumn,
            this.messageAttachmentIconColumn});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.messagesDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.messagesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.messagesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.messagesDataGridView.MultiSelect = false;
            this.messagesDataGridView.Name = "messagesDataGridView";
            this.messagesDataGridView.ReadOnly = true;
            this.messagesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.messagesDataGridView.RowHeadersVisible = false;
            this.messagesDataGridView.RowTemplate.Height = 32;
            this.messagesDataGridView.RowTemplate.ReadOnly = true;
            this.messagesDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.messagesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.messagesDataGridView.ShowEditingIcon = false;
            this.messagesDataGridView.Size = new System.Drawing.Size(979, 232);
            this.messagesDataGridView.TabIndex = 15;
            this.messagesDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.messagesDataGridView_CellMouseDown);
            this.messagesDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.messagesDataGridView_RowEnter);
            this.messagesDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.messagesDataGridView_RowsAdded);
            this.messagesDataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.messagesDataGridView_RowValidated);
            // 
            // messageProcessedColumn
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = "System.Drawing.Bitmap";
            this.messageProcessedColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.messageProcessedColumn.FillWeight = 30F;
            this.messageProcessedColumn.HeaderText = "";
            this.messageProcessedColumn.MinimumWidth = 30;
            this.messageProcessedColumn.Name = "messageProcessedColumn";
            this.messageProcessedColumn.ReadOnly = true;
            this.messageProcessedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.messageProcessedColumn.Width = 30;
            // 
            // messageMarkIconColumn
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = "System.Drawing.Bitmap";
            this.messageMarkIconColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.messageMarkIconColumn.FillWeight = 30F;
            this.messageMarkIconColumn.HeaderText = "";
            this.messageMarkIconColumn.MinimumWidth = 30;
            this.messageMarkIconColumn.Name = "messageMarkIconColumn";
            this.messageMarkIconColumn.ReadOnly = true;
            this.messageMarkIconColumn.ToolTipText = "Метка действия";
            this.messageMarkIconColumn.Width = 30;
            // 
            // messageDateColumn
            // 
            this.messageDateColumn.FillWeight = 120F;
            this.messageDateColumn.HeaderText = "Дата";
            this.messageDateColumn.MinimumWidth = 120;
            this.messageDateColumn.Name = "messageDateColumn";
            this.messageDateColumn.ReadOnly = true;
            this.messageDateColumn.ToolTipText = "Дата получения письма";
            this.messageDateColumn.Width = 120;
            // 
            // messageSenderColumn
            // 
            this.messageSenderColumn.HeaderText = "Отправитель";
            this.messageSenderColumn.Name = "messageSenderColumn";
            this.messageSenderColumn.ReadOnly = true;
            this.messageSenderColumn.Width = 250;
            // 
            // messageSubjectColumn
            // 
            this.messageSubjectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.messageSubjectColumn.HeaderText = "Тема";
            this.messageSubjectColumn.Name = "messageSubjectColumn";
            this.messageSubjectColumn.ReadOnly = true;
            // 
            // messageAttachmentIconColumn
            // 
            this.messageAttachmentIconColumn.HeaderText = "";
            this.messageAttachmentIconColumn.Name = "messageAttachmentIconColumn";
            this.messageAttachmentIconColumn.ReadOnly = true;
            this.messageAttachmentIconColumn.Width = 40;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.messageViewShowButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(979, 232);
            this.panel3.TabIndex = 14;
            // 
            // messageViewShowButton
            // 
            this.messageViewShowButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.messageViewShowButton.BackColor = System.Drawing.Color.Silver;
            this.messageViewShowButton.BackgroundImage = global::MailCollector.Properties.Resources.icons8_dotes_18;
            this.messageViewShowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.messageViewShowButton.FlatAppearance.BorderSize = 0;
            this.messageViewShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messageViewShowButton.Location = new System.Drawing.Point(459, 0);
            this.messageViewShowButton.Margin = new System.Windows.Forms.Padding(0);
            this.messageViewShowButton.MaximumSize = new System.Drawing.Size(60, 8);
            this.messageViewShowButton.MinimumSize = new System.Drawing.Size(60, 8);
            this.messageViewShowButton.Name = "messageViewShowButton";
            this.messageViewShowButton.Size = new System.Drawing.Size(60, 8);
            this.messageViewShowButton.TabIndex = 0;
            this.messageViewShowButton.UseVisualStyleBackColor = false;
            // 
            // messageViewerTabControl
            // 
            this.messageViewerTabControl.Controls.Add(this.textViewTabPage);
            this.messageViewerTabControl.Controls.Add(this.webViewTabPage);
            this.messageViewerTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageViewerTabControl.ItemSize = new System.Drawing.Size(58, 20);
            this.messageViewerTabControl.Location = new System.Drawing.Point(0, 0);
            this.messageViewerTabControl.Name = "messageViewerTabControl";
            this.messageViewerTabControl.SelectedIndex = 0;
            this.messageViewerTabControl.Size = new System.Drawing.Size(979, 139);
            this.messageViewerTabControl.TabIndex = 4;
            // 
            // textViewTabPage
            // 
            this.textViewTabPage.Controls.Add(this.richTextBox1);
            this.textViewTabPage.Location = new System.Drawing.Point(4, 24);
            this.textViewTabPage.Name = "textViewTabPage";
            this.textViewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.textViewTabPage.Size = new System.Drawing.Size(971, 111);
            this.textViewTabPage.TabIndex = 0;
            this.textViewTabPage.Text = "TEXT";
            this.textViewTabPage.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(965, 105);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // webViewTabPage
            // 
            this.webViewTabPage.Controls.Add(this.webViewer);
            this.webViewTabPage.Location = new System.Drawing.Point(4, 24);
            this.webViewTabPage.Name = "webViewTabPage";
            this.webViewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.webViewTabPage.Size = new System.Drawing.Size(924, 111);
            this.webViewTabPage.TabIndex = 1;
            this.webViewTabPage.Text = "HTML";
            this.webViewTabPage.UseVisualStyleBackColor = true;
            // 
            // webViewer
            // 
            this.webViewer.AllowNavigation = false;
            this.webViewer.AllowWebBrowserDrop = false;
            this.webViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webViewer.Location = new System.Drawing.Point(3, 3);
            this.webViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.webViewer.Name = "webViewer";
            this.webViewer.Size = new System.Drawing.Size(918, 105);
            this.webViewer.TabIndex = 0;
            this.webViewer.WebBrowserShortcutsEnabled = false;
            // 
            // attachmentFileListView
            // 
            this.attachmentFileListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attachmentFileListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.attachmentFileListView.HideSelection = false;
            this.attachmentFileListView.HoverSelection = true;
            this.attachmentFileListView.Location = new System.Drawing.Point(0, 139);
            this.attachmentFileListView.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.attachmentFileListView.Name = "attachmentFileListView";
            this.attachmentFileListView.Size = new System.Drawing.Size(979, 28);
            this.attachmentFileListView.TabIndex = 3;
            this.attachmentFileListView.UseCompatibleStateImageBehavior = false;
            this.attachmentFileListView.View = System.Windows.Forms.View.List;
            // 
            // actionsTabPage
            // 
            this.actionsTabPage.Controls.Add(this.actionsSplitContainer);
            this.actionsTabPage.Location = new System.Drawing.Point(4, 22);
            this.actionsTabPage.Name = "actionsTabPage";
            this.actionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.actionsTabPage.Size = new System.Drawing.Size(985, 410);
            this.actionsTabPage.TabIndex = 1;
            this.actionsTabPage.Text = "Шаблоны действий";
            this.actionsTabPage.UseVisualStyleBackColor = true;
            // 
            // actionsSplitContainer
            // 
            this.actionsSplitContainer.BackColor = System.Drawing.SystemColors.Control;
            this.actionsSplitContainer.DataBindings.Add(new System.Windows.Forms.Binding("Panel2Collapsed", global::MailCollector.Properties.Settings.Default, "ActionsDetailPanelCollapse", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.actionsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionsSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.actionsSplitContainer.IsSplitterFixed = true;
            this.actionsSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.actionsSplitContainer.Name = "actionsSplitContainer";
            // 
            // actionsSplitContainer.Panel1
            // 
            this.actionsSplitContainer.Panel1.Controls.Add(this.templatesDataGridView);
            this.actionsSplitContainer.Panel1.Controls.Add(this.panel1);
            // 
            // actionsSplitContainer.Panel2
            // 
            this.actionsSplitContainer.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.actionsSplitContainer.Panel2Collapsed = global::MailCollector.Properties.Settings.Default.ActionsDetailPanelCollapse;
            this.actionsSplitContainer.Size = new System.Drawing.Size(979, 404);
            this.actionsSplitContainer.SplitterDistance = 593;
            this.actionsSplitContainer.SplitterWidth = 1;
            this.actionsSplitContainer.TabIndex = 18;
            // 
            // templatesDataGridView
            // 
            this.templatesDataGridView.AllowUserToAddRows = false;
            this.templatesDataGridView.AllowUserToDeleteRows = false;
            this.templatesDataGridView.AllowUserToResizeColumns = false;
            this.templatesDataGridView.AllowUserToResizeRows = false;
            this.templatesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.templatesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.templatesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.templatesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.templatesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.templatesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.templatesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.templateUidColumn,
            this.templateEnabledColumn,
            this.templateSenderSearchModeColumn,
            this.templateSenderSearchTextColumn,
            this.templateSubjectSearchModeColumn,
            this.templateSubjectSearchTextColumn,
            this.templateBodySearchModeColumn,
            this.templateBodySearchTextColumn,
            this.templateAttachmentSearchModeColumn,
            this.templateAttachmentSearchTextColumn,
            this.templateActionColumn,
            this.templateDestinationColumn});
            this.templatesDataGridView.ContextMenuStrip = this.templatesContextMenuStrip;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.templatesDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.templatesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templatesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.templatesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.templatesDataGridView.MultiSelect = false;
            this.templatesDataGridView.Name = "templatesDataGridView";
            this.templatesDataGridView.ReadOnly = true;
            this.templatesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.templatesDataGridView.RowHeadersVisible = false;
            this.templatesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.templatesDataGridView.Size = new System.Drawing.Size(979, 404);
            this.templatesDataGridView.TabIndex = 18;
            this.templatesDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.templatesDataGridView_CellContentDoubleClick);
            this.templatesDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.templatesDataGridView_CellMouseDown);
            this.templatesDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.templatesDataGridView_CellMouseDoubleClick);
            // 
            // templateUidColumn
            // 
            this.templateUidColumn.HeaderText = "Номер";
            this.templateUidColumn.Name = "templateUidColumn";
            this.templateUidColumn.ReadOnly = true;
            this.templateUidColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.templateUidColumn.Width = 47;
            // 
            // templateEnabledColumn
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.NullValue = "0";
            this.templateEnabledColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.templateEnabledColumn.FalseValue = "0";
            this.templateEnabledColumn.HeaderText = "";
            this.templateEnabledColumn.MinimumWidth = 20;
            this.templateEnabledColumn.Name = "templateEnabledColumn";
            this.templateEnabledColumn.ReadOnly = true;
            this.templateEnabledColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.templateEnabledColumn.TrueValue = "1";
            this.templateEnabledColumn.Width = 20;
            // 
            // templateSenderSearchModeColumn
            // 
            this.templateSenderSearchModeColumn.HeaderText = "Режим поиска по отправителю";
            this.templateSenderSearchModeColumn.Name = "templateSenderSearchModeColumn";
            this.templateSenderSearchModeColumn.ReadOnly = true;
            this.templateSenderSearchModeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.templateSenderSearchModeColumn.Width = 171;
            // 
            // templateSenderSearchTextColumn
            // 
            this.templateSenderSearchTextColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.templateSenderSearchTextColumn.HeaderText = "Текст поиска отправителя";
            this.templateSenderSearchTextColumn.Name = "templateSenderSearchTextColumn";
            this.templateSenderSearchTextColumn.ReadOnly = true;
            this.templateSenderSearchTextColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.templateSenderSearchTextColumn.Width = 149;
            // 
            // templateSubjectSearchModeColumn
            // 
            this.templateSubjectSearchModeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.templateSubjectSearchModeColumn.HeaderText = "Режим поиска по теме";
            this.templateSubjectSearchModeColumn.Name = "templateSubjectSearchModeColumn";
            this.templateSubjectSearchModeColumn.ReadOnly = true;
            this.templateSubjectSearchModeColumn.Width = 149;
            // 
            // templateSubjectSearchTextColumn
            // 
            this.templateSubjectSearchTextColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.templateSubjectSearchTextColumn.HeaderText = "Текст поиска по теме теме";
            this.templateSubjectSearchTextColumn.Name = "templateSubjectSearchTextColumn";
            this.templateSubjectSearchTextColumn.ReadOnly = true;
            this.templateSubjectSearchTextColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.templateSubjectSearchTextColumn.Width = 153;
            // 
            // templateBodySearchModeColumn
            // 
            this.templateBodySearchModeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.templateBodySearchModeColumn.HeaderText = "Режим поиска по телу";
            this.templateBodySearchModeColumn.Name = "templateBodySearchModeColumn";
            this.templateBodySearchModeColumn.ReadOnly = true;
            this.templateBodySearchModeColumn.Width = 146;
            // 
            // templateBodySearchTextColumn
            // 
            this.templateBodySearchTextColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.templateBodySearchTextColumn.HeaderText = "Текст поиска по телу";
            this.templateBodySearchTextColumn.Name = "templateBodySearchTextColumn";
            this.templateBodySearchTextColumn.ReadOnly = true;
            this.templateBodySearchTextColumn.Width = 141;
            // 
            // templateAttachmentSearchModeColumn
            // 
            this.templateAttachmentSearchModeColumn.HeaderText = "Режим поиска вложения";
            this.templateAttachmentSearchModeColumn.Name = "templateAttachmentSearchModeColumn";
            this.templateAttachmentSearchModeColumn.ReadOnly = true;
            this.templateAttachmentSearchModeColumn.Width = 159;
            // 
            // templateAttachmentSearchTextColumn
            // 
            this.templateAttachmentSearchTextColumn.HeaderText = "Текст поиска по вложению";
            this.templateAttachmentSearchTextColumn.Name = "templateAttachmentSearchTextColumn";
            this.templateAttachmentSearchTextColumn.ReadOnly = true;
            this.templateAttachmentSearchTextColumn.Width = 171;
            // 
            // templateActionColumn
            // 
            this.templateActionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.templateActionColumn.HeaderText = "Действие";
            this.templateActionColumn.Name = "templateActionColumn";
            this.templateActionColumn.ReadOnly = true;
            this.templateActionColumn.Width = 82;
            // 
            // templateDestinationColumn
            // 
            this.templateDestinationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.templateDestinationColumn.HeaderText = "Назначение";
            this.templateDestinationColumn.Name = "templateDestinationColumn";
            this.templateDestinationColumn.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.actionShowDetailButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 404);
            this.panel1.TabIndex = 17;
            // 
            // actionShowDetailButton
            // 
            this.actionShowDetailButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.actionShowDetailButton.BackColor = System.Drawing.Color.Silver;
            this.actionShowDetailButton.FlatAppearance.BorderSize = 0;
            this.actionShowDetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionShowDetailButton.Location = new System.Drawing.Point(1, 177);
            this.actionShowDetailButton.MaximumSize = new System.Drawing.Size(8, 50);
            this.actionShowDetailButton.MinimumSize = new System.Drawing.Size(8, 50);
            this.actionShowDetailButton.Name = "actionShowDetailButton";
            this.actionShowDetailButton.Size = new System.Drawing.Size(8, 50);
            this.actionShowDetailButton.TabIndex = 0;
            this.actionShowDetailButton.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(96, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.groupBox2);
            this.settingsTabPage.Controls.Add(this.groupBox1);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTabPage.Size = new System.Drawing.Size(985, 410);
            this.settingsTabPage.TabIndex = 2;
            this.settingsTabPage.Text = "Общие настройки";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.serverPasswordTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.serverLoginTextBox);
            this.groupBox2.Controls.Add(this.serverUseSSLCheckBox);
            this.groupBox2.Controls.Add(this.serverPortTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.serverUrlTextBox);
            this.groupBox2.Location = new System.Drawing.Point(448, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 202);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки подключения к почтовому серверу";
            // 
            // serverPasswordTextBox
            // 
            this.serverPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MailCollector.Properties.Settings.Default, "MailServerPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.serverPasswordTextBox.Location = new System.Drawing.Point(28, 156);
            this.serverPasswordTextBox.Name = "serverPasswordTextBox";
            this.serverPasswordTextBox.PasswordChar = '*';
            this.serverPasswordTextBox.PromptChar = ' ';
            this.serverPasswordTextBox.Size = new System.Drawing.Size(271, 20);
            this.serverPasswordTextBox.TabIndex = 13;
            this.serverPasswordTextBox.Text = global::MailCollector.Properties.Settings.Default.MailServerPassword;
            this.serverPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Логин:";
            // 
            // serverLoginTextBox
            // 
            this.serverLoginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MailCollector.Properties.Settings.Default, "MailServerLogin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.serverLoginTextBox.Location = new System.Drawing.Point(28, 112);
            this.serverLoginTextBox.Name = "serverLoginTextBox";
            this.serverLoginTextBox.Size = new System.Drawing.Size(270, 20);
            this.serverLoginTextBox.TabIndex = 9;
            this.serverLoginTextBox.Text = global::MailCollector.Properties.Settings.Default.MailServerLogin;
            // 
            // serverUseSSLCheckBox
            // 
            this.serverUseSSLCheckBox.AutoSize = true;
            this.serverUseSSLCheckBox.Checked = global::MailCollector.Properties.Settings.Default.MailServerUseSSL;
            this.serverUseSSLCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.serverUseSSLCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MailCollector.Properties.Settings.Default, "MailServerUseSSL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.serverUseSSLCheckBox.Location = new System.Drawing.Point(28, 70);
            this.serverUseSSLCheckBox.Name = "serverUseSSLCheckBox";
            this.serverUseSSLCheckBox.Size = new System.Drawing.Size(185, 17);
            this.serverUseSSLCheckBox.TabIndex = 8;
            this.serverUseSSLCheckBox.Text = "Использовать SSL соединение";
            this.serverUseSSLCheckBox.UseVisualStyleBackColor = true;
            // 
            // serverPortTextBox
            // 
            this.serverPortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MailCollector.Properties.Settings.Default, "MailServerPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.serverPortTextBox.Location = new System.Drawing.Point(241, 44);
            this.serverPortTextBox.Name = "serverPortTextBox";
            this.serverPortTextBox.PromptChar = ' ';
            this.serverPortTextBox.Size = new System.Drawing.Size(57, 20);
            this.serverPortTextBox.TabIndex = 7;
            this.serverPortTextBox.Text = global::MailCollector.Properties.Settings.Default.MailServerPort;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Порт:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Почтовый сервер:";
            // 
            // serverUrlTextBox
            // 
            this.serverUrlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MailCollector.Properties.Settings.Default, "MailServerUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.serverUrlTextBox.Location = new System.Drawing.Point(27, 44);
            this.serverUrlTextBox.Name = "serverUrlTextBox";
            this.serverUrlTextBox.Size = new System.Drawing.Size(208, 20);
            this.serverUrlTextBox.TabIndex = 0;
            this.serverUrlTextBox.Text = global::MailCollector.Properties.Settings.Default.MailServerUrl;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.saveFolderPathTextBox);
            this.groupBox1.Controls.Add(this.selectSaveFolderButton);
            this.groupBox1.Location = new System.Drawing.Point(19, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 202);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка сохранения вложений";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь для сохранения:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(19, 82);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(223, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Сохранять вложения в папки по датам";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // saveFolderPathTextBox
            // 
            this.saveFolderPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MailCollector.Properties.Settings.Default, "SaveFolderPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.saveFolderPathTextBox.Location = new System.Drawing.Point(19, 50);
            this.saveFolderPathTextBox.Name = "saveFolderPathTextBox";
            this.saveFolderPathTextBox.Size = new System.Drawing.Size(338, 20);
            this.saveFolderPathTextBox.TabIndex = 0;
            this.saveFolderPathTextBox.Text = global::MailCollector.Properties.Settings.Default.SaveFolderPath;
            // 
            // selectSaveFolderButton
            // 
            this.selectSaveFolderButton.Location = new System.Drawing.Point(357, 49);
            this.selectSaveFolderButton.Name = "selectSaveFolderButton";
            this.selectSaveFolderButton.Size = new System.Drawing.Size(24, 22);
            this.selectSaveFolderButton.TabIndex = 1;
            this.selectSaveFolderButton.Text = "...";
            this.selectSaveFolderButton.UseVisualStyleBackColor = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::MailCollector.Properties.Resources.icons8_circle_gray_8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // updateMarkButton
            // 
            this.updateMarkButton.Location = new System.Drawing.Point(564, 21);
            this.updateMarkButton.Name = "updateMarkButton";
            this.updateMarkButton.Size = new System.Drawing.Size(102, 23);
            this.updateMarkButton.TabIndex = 20;
            this.updateMarkButton.Text = "Обновить метки";
            this.updateMarkButton.UseVisualStyleBackColor = true;
            this.updateMarkButton.Click += new System.EventHandler(this.updateMarkButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 519);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Name = "MainForm";
            this.Text = "Сборщик писем";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.templatesContextMenuStrip.ResumeLayout(false);
            this.messagesContextMenuStrip.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.messagesTabPage.ResumeLayout(false);
            this.messagesSplitContainer.Panel1.ResumeLayout(false);
            this.messagesSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.messagesSplitContainer)).EndInit();
            this.messagesSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.messagesDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.messageViewerTabControl.ResumeLayout(false);
            this.textViewTabPage.ResumeLayout(false);
            this.webViewTabPage.ResumeLayout(false);
            this.actionsTabPage.ResumeLayout(false);
            this.actionsSplitContainer.Panel1.ResumeLayout(false);
            this.actionsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.actionsSplitContainer)).EndInit();
            this.actionsSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.templatesDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.settingsTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox mailboxesComboBox;
        private System.Windows.Forms.Button receiveMailButton;
        private System.Windows.Forms.DateTimePicker lastDateTimePicker;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel countStatusLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox manualDatetimeCheckBox;
        private System.Windows.Forms.ContextMenuStrip templatesContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTemplateToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip messagesContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem createTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageSetMarkByTemplatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ToolStripMenuItem messageSetMarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageMarkSaveAttachmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageMarkForwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageMarkBookmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageMarkSpamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageMarkDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageClearMarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageProccessToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker messagesReceiveBackgroundWorker;
        private System.ComponentModel.BackgroundWorker messagesProccessBackgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage messagesTabPage;
        private System.Windows.Forms.SplitContainer messagesSplitContainer;
        private System.Windows.Forms.DataGridView messagesDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn messageProcessedColumn;
        private System.Windows.Forms.DataGridViewImageColumn messageMarkIconColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageSenderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageSubjectColumn;
        private System.Windows.Forms.DataGridViewImageColumn messageAttachmentIconColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button messageViewShowButton;
        private System.Windows.Forms.TabPage actionsTabPage;
        private System.Windows.Forms.SplitContainer actionsSplitContainer;
        private System.Windows.Forms.DataGridView templatesDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button actionShowDetailButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox serverPasswordTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serverLoginTextBox;
        private System.Windows.Forms.CheckBox serverUseSSLCheckBox;
        private System.Windows.Forms.MaskedTextBox serverPortTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serverUrlTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox saveFolderPathTextBox;
        private System.Windows.Forms.Button selectSaveFolderButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem messageSaveAttachmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageForwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ListView attachmentFileListView;
        private System.Windows.Forms.TabControl messageViewerTabControl;
        private System.Windows.Forms.TabPage textViewTabPage;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage webViewTabPage;
        private System.Windows.Forms.WebBrowser webViewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn templateUidColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn templateEnabledColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn templateSenderSearchModeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn templateSenderSearchTextColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn templateSubjectSearchModeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn templateSubjectSearchTextColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn templateBodySearchModeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn templateBodySearchTextColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn templateAttachmentSearchModeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn templateAttachmentSearchTextColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn templateActionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn templateDestinationColumn;
        private System.Windows.Forms.CheckBox messageAutoMarkCheckBox;
        private System.Windows.Forms.CheckBox messageAutoReceiveCheckBox;
        private System.Windows.Forms.Button updateMarkButton;
    }
}

