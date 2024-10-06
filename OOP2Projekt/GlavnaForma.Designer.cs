namespace OOP2Projekt
{
    partial class GlavnaForma
    {
        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            comboBoxLanguage = new System.Windows.Forms.ComboBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            buttonTrackProgress = new System.Windows.Forms.Button();
            richTextBoxMealPlan = new System.Windows.Forms.RichTextBox();
            buttonGetMealPlan = new System.Windows.Forms.Button();
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
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Cog;
            iconButton1.IconColor = System.Drawing.Color.DimGray;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 36;
            iconButton1.Location = new System.Drawing.Point(1037, 12);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new System.Drawing.Size(50, 40);
            iconButton1.TabIndex = 1;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // buttonTrackProgress
            // 
            buttonTrackProgress.Location = new System.Drawing.Point(10, 285);
            buttonTrackProgress.Name = "buttonTrackProgress";
            buttonTrackProgress.Size = new System.Drawing.Size(75, 23);
            buttonTrackProgress.TabIndex = 2;
            buttonTrackProgress.Text = "Progress";
            buttonTrackProgress.UseVisualStyleBackColor = true;
            buttonTrackProgress.Click += buttonTrackProgress_Click;
            // 
            // richTextBoxMealPlan
            // 
            richTextBoxMealPlan.Location = new System.Drawing.Point(10, 50);
            richTextBoxMealPlan.Name = "richTextBoxMealPlan";
            richTextBoxMealPlan.Size = new System.Drawing.Size(400, 200);
            richTextBoxMealPlan.TabIndex = 3;
            richTextBoxMealPlan.Text = "";
            // 
            // buttonGetMealPlan
            // 
            buttonGetMealPlan.Location = new System.Drawing.Point(10, 256);
            buttonGetMealPlan.Name = "buttonGetMealPlan";
            buttonGetMealPlan.Size = new System.Drawing.Size(100, 23);
            buttonGetMealPlan.TabIndex = 4;
            buttonGetMealPlan.Text = "Get Meal Plan";
            buttonGetMealPlan.UseVisualStyleBackColor = true;
            buttonGetMealPlan.Click += buttonGetMealPlan_Click;
            // 
            // GlavnaForma
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1099, 556);
            Controls.Add(buttonTrackProgress);
            Controls.Add(iconButton1);
            Controls.Add(richTextBoxMealPlan);
            Controls.Add(buttonGetMealPlan);
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
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Button buttonTrackProgress;
        private System.Windows.Forms.RichTextBox richTextBoxMealPlan;
        private System.Windows.Forms.Button buttonGetMealPlan;
    }
}