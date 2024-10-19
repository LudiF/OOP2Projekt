namespace OOP2Projekt
{
    partial class SettingsForm
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
            comboBoxLanguage = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            buttonSaveSettings = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            comboBoxTheme = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).BeginInit();
            SuspendLayout();
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Items.AddRange(new object[] { "English", "Hrvatski" });
            comboBoxLanguage.Location = new System.Drawing.Point(21, 41);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new System.Drawing.Size(121, 23);
            comboBoxLanguage.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Language";
            // 
            // numericUpDownWidth
            // 
            numericUpDownWidth.Location = new System.Drawing.Point(21, 108);
            numericUpDownWidth.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numericUpDownWidth.Name = "numericUpDownWidth";
            numericUpDownWidth.Size = new System.Drawing.Size(120, 23);
            numericUpDownWidth.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(21, 90);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Width";
            // 
            // numericUpDownHeight
            // 
            numericUpDownHeight.Location = new System.Drawing.Point(22, 165);
            numericUpDownHeight.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numericUpDownHeight.Name = "numericUpDownHeight";
            numericUpDownHeight.Size = new System.Drawing.Size(120, 23);
            numericUpDownHeight.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(21, 147);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "Height";
            // 
            // buttonSaveSettings
            // 
            buttonSaveSettings.Location = new System.Drawing.Point(21, 217);
            buttonSaveSettings.Name = "buttonSaveSettings";
            buttonSaveSettings.Size = new System.Drawing.Size(120, 23);
            buttonSaveSettings.TabIndex = 6;
            buttonSaveSettings.Text = "Save";
            buttonSaveSettings.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(21, 258);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(116, 23);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // comboBoxTheme
            // 
            comboBoxTheme.FormattingEnabled = true;
            comboBoxTheme.Items.AddRange(new object[] { "Light", "Dark" });
            comboBoxTheme.Location = new System.Drawing.Point(212, 44);
            comboBoxTheme.Name = "comboBoxTheme";
            comboBoxTheme.Size = new System.Drawing.Size(121, 23);
            comboBoxTheme.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(212, 23);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(43, 15);
            label4.TabIndex = 9;
            label4.Text = "Theme";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label4);
            Controls.Add(comboBoxTheme);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSaveSettings);
            Controls.Add(label3);
            Controls.Add(numericUpDownHeight);
            Controls.Add(label2);
            Controls.Add(numericUpDownWidth);
            Controls.Add(label1);
            Controls.Add(comboBoxLanguage);
            Name = "SettingsForm";
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxTheme;
        private System.Windows.Forms.Label label4;
    }
}