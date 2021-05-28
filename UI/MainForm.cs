using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.DataProcesser;

namespace UI
{
    public partial class MainForm : Form
    {
        private List<string> _paths;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ProcessSetFilesButton(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Word Documents|*.doc;*.docx";
            ofd.Multiselect = true;
            ofd.RestoreDirectory = true;
            _paths = new List<string>();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var fileName in ofd.FileNames)
                {
                    if (filesTextBox.Text.Length == 0)
                        filesTextBox.Text = Path.GetDirectoryName(fileName);
                    else
                        filesTextBox.AppendText("\r\n" + fileName);
                    _paths.Add(fileName);
                }

            }
            
        }

        private void ProcessSettingsButtonClick(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.Show();
        }
        private void TransferDataButtonClick(object sender, EventArgs e)
        {
            var dp = new DocumetProcesser() { Paths = _paths };
            foreach (var path in _paths)
            {
                dp.GetRowsFromDocx();
            }
        }

        
    }
}
