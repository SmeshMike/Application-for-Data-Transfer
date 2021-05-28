using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class SettinsForm : Form
    {
        string path = @$"{Directory.GetCurrentDirectory()}\tablepath.txt";
        public SettinsForm()
        {
            InitializeComponent();
        }

        private void ChangePathButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Documents|*.xls;*.xlsx";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tablePathTextBox.Text = ofd.SafeFileName;
                if (File.Exists(path))
                {
                    File.WriteAllText(path, ofd.SafeFileName);
                }
            }

        }

        private void ProcessSettinsFormLoad(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                using var sr = File.OpenText(path);
                tablePathTextBox.Text = sr.ReadToEnd();
            }
            else
            {
                File.Create(path);
            }
        }
    }
}
