namespace OOP2Projekt
{
    partial class CalorieIntakeForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dataGridViewCalories = new System.Windows.Forms.DataGridView();
            chartCalories = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonAddCalories = new System.Windows.Forms.Button();
            buttonDeleteCalories = new System.Windows.Forms.Button();
            buttonEditCalories = new System.Windows.Forms.Button();
            textBoxCalories = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            dateTimePickerCalories = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartCalories).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCalories
            // 
            dataGridViewCalories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCalories.Location = new System.Drawing.Point(378, 36);
            dataGridViewCalories.Name = "dataGridViewCalories";
            dataGridViewCalories.Size = new System.Drawing.Size(404, 150);
            dataGridViewCalories.TabIndex = 0;
            // 
            // chartCalories
            // 
            chartArea1.Name = "ChartArea1";
            chartCalories.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartCalories.Legends.Add(legend1);
            chartCalories.Location = new System.Drawing.Point(37, 248);
            chartCalories.Name = "chartCalories";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartCalories.Series.Add(series1);
            chartCalories.Size = new System.Drawing.Size(640, 300);
            chartCalories.TabIndex = 1;
            chartCalories.Text = "chart1";
            // 
            // buttonAddCalories
            // 
            buttonAddCalories.Location = new System.Drawing.Point(38, 569);
            buttonAddCalories.Name = "buttonAddCalories";
            buttonAddCalories.Size = new System.Drawing.Size(75, 23);
            buttonAddCalories.TabIndex = 2;
            buttonAddCalories.Text = "Add";
            buttonAddCalories.UseVisualStyleBackColor = true;
            buttonAddCalories.Click += buttonAddCalories_Click;
            // 
            // buttonDeleteCalories
            // 
            buttonDeleteCalories.Location = new System.Drawing.Point(128, 569);
            buttonDeleteCalories.Name = "buttonDeleteCalories";
            buttonDeleteCalories.Size = new System.Drawing.Size(75, 23);
            buttonDeleteCalories.TabIndex = 3;
            buttonDeleteCalories.Text = "Delete";
            buttonDeleteCalories.UseVisualStyleBackColor = true;
            buttonDeleteCalories.Click += buttonDeleteCalories_Click;
            // 
            // buttonEditCalories
            // 
            buttonEditCalories.Location = new System.Drawing.Point(222, 569);
            buttonEditCalories.Name = "buttonEditCalories";
            buttonEditCalories.Size = new System.Drawing.Size(75, 23);
            buttonEditCalories.TabIndex = 4;
            buttonEditCalories.Text = "Edit";
            buttonEditCalories.UseVisualStyleBackColor = true;
            buttonEditCalories.Click += buttonEditCalories_Click;
            // 
            // textBoxCalories
            // 
            textBoxCalories.Location = new System.Drawing.Point(37, 93);
            textBoxCalories.Name = "textBoxCalories";
            textBoxCalories.Size = new System.Drawing.Size(100, 23);
            textBoxCalories.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(37, 75);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 15);
            label1.TabIndex = 6;
            label1.Text = "Calories";
            // 
            // dateTimePickerCalories
            // 
            dateTimePickerCalories.Location = new System.Drawing.Point(37, 122);
            dateTimePickerCalories.Name = "dateTimePickerCalories";
            dateTimePickerCalories.Size = new System.Drawing.Size(200, 23);
            dateTimePickerCalories.TabIndex = 7;
            // 
            // CalorieIntakeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(831, 627);
            Controls.Add(dateTimePickerCalories);
            Controls.Add(label1);
            Controls.Add(textBoxCalories);
            Controls.Add(buttonEditCalories);
            Controls.Add(buttonDeleteCalories);
            Controls.Add(buttonAddCalories);
            Controls.Add(chartCalories);
            Controls.Add(dataGridViewCalories);
            Name = "CalorieIntakeForm";
            Text = "CalorieIntakeForm";
            Load += CalorieIntakeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalories).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartCalories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCalories;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCalories;
        private System.Windows.Forms.Button buttonAddCalories;
        private System.Windows.Forms.Button buttonDeleteCalories;
        private System.Windows.Forms.Button buttonEditCalories;
        private System.Windows.Forms.TextBox textBoxCalories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerCalories;
    }
}