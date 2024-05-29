using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailCollector
{
    public partial class TemplateForm : Form
    {
        public TemplateForm()
        {
            InitializeComponent();
        }

        private void senderSearchModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            senderTextBox.Enabled = senderSearchModeComboBox.SelectedIndex != 0;
            if (senderSearchModeComboBox.SelectedIndex == 0) senderTextBox.Clear();
        }

        private void subjectSearchModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            subjectTextBox.Enabled = subjectSearchModeComboBox.SelectedIndex != 0;
            if (subjectSearchModeComboBox.SelectedIndex == 0) subjectTextBox.Clear();
        }

        private void bodySearchModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bodyTextBox.Enabled = bodySearchModeComboBox.SelectedIndex != 0;
            if (bodySearchModeComboBox.SelectedIndex == 0) bodyTextBox.Clear();
        }

        private void attachmentSearchModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            attachmentTextBox.Enabled = attachmentSearchModeComboBox.SelectedIndex != 0;
            if (attachmentSearchModeComboBox.SelectedIndex == 0) attachmentTextBox.Clear();
        }

        private void actionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            destinationTextBox.Enabled = actionComboBox.SelectedIndex != 0;
            if (actionComboBox.SelectedIndex == 0) destinationTextBox.Clear();
        }


    }
}
