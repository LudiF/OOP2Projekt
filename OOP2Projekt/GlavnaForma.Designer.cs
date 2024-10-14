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
            label2 = new System.Windows.Forms.Label();
            numericUpDownCalories = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            pictureBoxMeal = new System.Windows.Forms.PictureBox();
            progressBarDownload = new System.Windows.Forms.ProgressBar();
            comboBoxSpeed = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCalories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMeal).BeginInit();
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
            buttonTrackProgress.Location = new System.Drawing.Point(10, 390);
            buttonTrackProgress.Name = "buttonTrackProgress";
            buttonTrackProgress.Size = new System.Drawing.Size(296, 26);
            buttonTrackProgress.TabIndex = 2;
            buttonTrackProgress.Text = "Track Weight Progress";
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
            buttonGetMealPlan.Location = new System.Drawing.Point(185, 348);
            buttonGetMealPlan.Name = "buttonGetMealPlan";
            buttonGetMealPlan.Size = new System.Drawing.Size(121, 26);
            buttonGetMealPlan.TabIndex = 4;
            buttonGetMealPlan.Text = "Get Meal Plan";
            buttonGetMealPlan.UseVisualStyleBackColor = true;
            buttonGetMealPlan.Click += buttonGetMealPlan_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 330);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 15);
            label2.TabIndex = 7;
            label2.Text = "Calories";
            // 
            // numericUpDownCalories
            // 
            numericUpDownCalories.Location = new System.Drawing.Point(10, 348);
            numericUpDownCalories.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownCalories.Name = "numericUpDownCalories";
            numericUpDownCalories.Size = new System.Drawing.Size(169, 23);
            numericUpDownCalories.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 15);
            label1.TabIndex = 11;
            label1.Text = "Today's menu";
            // 
            // pictureBoxMeal
            // 
            pictureBoxMeal.Location = new System.Drawing.Point(444, 69);
            pictureBoxMeal.Name = "pictureBoxMeal";
            pictureBoxMeal.Size = new System.Drawing.Size(100, 50);
            pictureBoxMeal.TabIndex = 12;
            pictureBoxMeal.TabStop = false;
            // 
            // progressBarDownload
            // 
            progressBarDownload.Location = new System.Drawing.Point(12, 304);
            progressBarDownload.Name = "progressBarDownload";
            progressBarDownload.Size = new System.Drawing.Size(294, 23);
            progressBarDownload.TabIndex = 13;
            // 
            // comboBoxSpeed
            // 
            comboBoxSpeed.FormattingEnabled = true;
            comboBoxSpeed.Location = new System.Drawing.Point(185, 271);
            comboBoxSpeed.Name = "comboBoxSpeed";
            comboBoxSpeed.Size = new System.Drawing.Size(121, 23);
            comboBoxSpeed.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(10, 274);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(153, 15);
            label3.TabIndex = 15;
            label3.Text = "Odaberi brzinu preuzimanja";
            // 
            // GlavnaForma
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1099, 556);
            Controls.Add(label3);
            Controls.Add(comboBoxSpeed);
            Controls.Add(progressBarDownload);
            Controls.Add(pictureBoxMeal);
            Controls.Add(label1);
            Controls.Add(numericUpDownCalories);
            Controls.Add(label2);
            Controls.Add(buttonTrackProgress);
            Controls.Add(iconButton1);
            Controls.Add(richTextBoxMealPlan);
            Controls.Add(buttonGetMealPlan);
            Controls.Add(comboBoxLanguage);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "GlavnaForma";
            Text = "GlavnaForma";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCalories).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMeal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.PictureBox pictureBoxUploadProfile;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Button buttonTrackProgress;
        private System.Windows.Forms.RichTextBox richTextBoxMealPlan;
        private System.Windows.Forms.Button buttonGetMealPlan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownCalories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxMeal;
        private System.Windows.Forms.ProgressBar progressBarDownload;
        private System.Windows.Forms.ComboBox comboBoxSpeed;
        private System.Windows.Forms.Label label3;
    }
}