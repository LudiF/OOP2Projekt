namespace OOP2Projekt
{
    partial class GlavnaForma
    {
        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            comboBoxLanguage = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Location = new System.Drawing.Point(1270, 14);
            comboBoxLanguage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new System.Drawing.Size(140, 23);
            comboBoxLanguage.TabIndex = 0;
            // 
            // GlavnaForma
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1426, 717);
            Controls.Add(comboBoxLanguage);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "GlavnaForma";
            Text = "GlavnaForma";
            Load += GlavnaForma_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.PictureBox pictureBoxUploadProfile;
    }
}