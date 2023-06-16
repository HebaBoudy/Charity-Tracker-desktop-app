namespace DBapplication
{
    partial class managerial_report2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.statisticsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalCharityTrackerDataSet8 = new DBapplication.FinalCharityTrackerDataSet8();
            this.finalCharityTrackerDataSet7 = new DBapplication.FinalCharityTrackerDataSet7();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new DBapplication.FinalCharityTrackerDataSet7TableAdapters.EmployeeTableAdapter();
            this.statisticsTableAdapter = new DBapplication.FinalCharityTrackerDataSet8TableAdapters.StatisticsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.finalCharityTrackerDataSet9 = new DBapplication.FinalCharityTrackerDataSet9();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter1 = new DBapplication.FinalCharityTrackerDataSet9TableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalCharityTrackerDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalCharityTrackerDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalCharityTrackerDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticsBindingSource
            // 
            this.statisticsBindingSource.DataMember = "Statistics";
            this.statisticsBindingSource.DataSource = this.finalCharityTrackerDataSet8;
            // 
            // finalCharityTrackerDataSet8
            // 
            this.finalCharityTrackerDataSet8.DataSetName = "FinalCharityTrackerDataSet8";
            this.finalCharityTrackerDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // finalCharityTrackerDataSet7
            // 
            this.finalCharityTrackerDataSet7.DataSetName = "FinalCharityTrackerDataSet7";
            this.finalCharityTrackerDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.finalCharityTrackerDataSet7;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // statisticsTableAdapter
            // 
            this.statisticsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Average salary of each department :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.employeeBindingSource1;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(177, 103);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueMember = "Gender";
            series2.YValueMembers = "Salary";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(521, 300);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // finalCharityTrackerDataSet9
            // 
            this.finalCharityTrackerDataSet9.DataSetName = "FinalCharityTrackerDataSet9";
            this.finalCharityTrackerDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.finalCharityTrackerDataSet9;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // managerial_report2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Name = "managerial_report2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "managerial_report2";
            this.Load += new System.EventHandler(this.managerial_report2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statisticsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalCharityTrackerDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalCharityTrackerDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalCharityTrackerDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FinalCharityTrackerDataSet7 finalCharityTrackerDataSet7;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private FinalCharityTrackerDataSet7TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private FinalCharityTrackerDataSet8 finalCharityTrackerDataSet8;
        private System.Windows.Forms.BindingSource statisticsBindingSource;
        private FinalCharityTrackerDataSet8TableAdapters.StatisticsTableAdapter statisticsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private FinalCharityTrackerDataSet9 finalCharityTrackerDataSet9;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private FinalCharityTrackerDataSet9TableAdapters.EmployeeTableAdapter employeeTableAdapter1;
    }
}