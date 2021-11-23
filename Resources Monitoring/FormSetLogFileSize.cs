using System;
using System.Windows.Forms;

namespace Resources_Monitoring
{
    public partial class FormSetLogFileSize : Form
    {
        public StateSettings state = new StateSettings();
        public FormSetLogFileSize(StateSettings state)
        {
            InitializeComponent();
            this.state = state;
            numericUpDown1.Value = (decimal)state.getFileSize() / 1000000;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            state.setFileSize((double)numericUpDown1.Value * 1000000);
            state.saveSettings();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
