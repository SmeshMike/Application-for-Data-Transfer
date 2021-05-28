namespace UI
{
    partial class SettinsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettinsForm));
            this.tablePathTextBox = new System.Windows.Forms.TextBox();
            this.changePathButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tablePathTextBox
            // 
            this.tablePathTextBox.Location = new System.Drawing.Point(13, 13);
            this.tablePathTextBox.Name = "tablePathTextBox";
            this.tablePathTextBox.Size = new System.Drawing.Size(289, 25);
            this.tablePathTextBox.TabIndex = 1;
            // 
            // changePathButton
            // 
            this.changePathButton.Font = new System.Drawing.Font("Segoe UI", 11.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changePathButton.Location = new System.Drawing.Point(309, 13);
            this.changePathButton.Name = "changePathButton";
            this.changePathButton.Size = new System.Drawing.Size(50, 25);
            this.changePathButton.TabIndex = 0;
            this.changePathButton.Text = "...";
            this.changePathButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.changePathButton.UseVisualStyleBackColor = true;
            this.changePathButton.Click += new System.EventHandler(this.ChangePathButtonClick);
            // 
            // SettinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 48);
            this.Controls.Add(this.changePathButton);
            this.Controls.Add(this.tablePathTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettinsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.ProcessSettinsFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tablePathTextBox;
        private System.Windows.Forms.Button changePathButton;
    }
}