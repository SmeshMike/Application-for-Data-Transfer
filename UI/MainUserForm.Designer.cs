namespace UI
{
    partial class MainUserForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUserForm));
            this.setFilesButton = new System.Windows.Forms.Button();
            this.filesTextBox = new System.Windows.Forms.TextBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.transferDataButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // setFilesButton
            // 
            this.setFilesButton.Location = new System.Drawing.Point(450, 227);
            this.setFilesButton.Name = "setFilesButton";
            this.setFilesButton.Size = new System.Drawing.Size(119, 30);
            this.setFilesButton.TabIndex = 0;
            this.setFilesButton.Text = "Выбрать файлы";
            this.setFilesButton.UseVisualStyleBackColor = true;
            this.setFilesButton.Click += new System.EventHandler(this.ProcessSetFilesButton);
            // 
            // filesTextBox
            // 
            this.filesTextBox.Location = new System.Drawing.Point(13, 13);
            this.filesTextBox.Multiline = true;
            this.filesTextBox.Name = "filesTextBox";
            this.filesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.filesTextBox.Size = new System.Drawing.Size(556, 207);
            this.filesTextBox.TabIndex = 1;
            this.filesTextBox.WordWrap = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsButton.BackgroundImage")));
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.Location = new System.Drawing.Point(414, 226);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(30, 30);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.ProcessSettingsButtonClick);
            // 
            // transferDataButton
            // 
            this.transferDataButton.Location = new System.Drawing.Point(414, 262);
            this.transferDataButton.Name = "transferDataButton";
            this.transferDataButton.Size = new System.Drawing.Size(155, 30);
            this.transferDataButton.TabIndex = 2;
            this.transferDataButton.Text = "Перенести данные";
            this.transferDataButton.UseVisualStyleBackColor = true;
            this.transferDataButton.Click += new System.EventHandler(this.TransferDataButtonClick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 262);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(271, 30);
            this.progressBar.TabIndex = 3;
            // 
            // MainUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 300);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.transferDataButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.filesTextBox);
            this.Controls.Add(this.setFilesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setFilesButton;
        private System.Windows.Forms.TextBox filesTextBox;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button transferDataButton;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

