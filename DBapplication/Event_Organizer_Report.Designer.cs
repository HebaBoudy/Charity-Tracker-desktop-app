namespace DBapplication
{
    partial class Event_Organizer_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Event_Organizer_Report));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.max_cost = new System.Windows.Forms.Label();
            this.max_participants = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.finalCharityTrackerDataSet5 = new DBapplication.FinalCharityTrackerDataSet5();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventTableAdapter = new DBapplication.FinalCharityTrackerDataSet5TableAdapters.EventTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalCharityTrackerDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DBapplication.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1221, 745);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(51, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Events details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 662);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Event with the highest cost :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(12, 685);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Event with the highest no of participants:";
            // 
            // max_cost
            // 
            this.max_cost.AutoSize = true;
            this.max_cost.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_cost.ForeColor = System.Drawing.Color.SteelBlue;
            this.max_cost.Location = new System.Drawing.Point(277, 662);
            this.max_cost.Name = "max_cost";
            this.max_cost.Size = new System.Drawing.Size(21, 23);
            this.max_cost.TabIndex = 6;
            this.max_cost.Text = "y";
            // 
            // max_participants
            // 
            this.max_participants.AutoSize = true;
            this.max_participants.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_participants.ForeColor = System.Drawing.Color.SteelBlue;
            this.max_participants.Location = new System.Drawing.Point(395, 685);
            this.max_participants.Name = "max_participants";
            this.max_participants.Size = new System.Drawing.Size(21, 23);
            this.max_participants.TabIndex = 7;
            this.max_participants.Text = "y";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // finalCharityTrackerDataSet5
            // 
            this.finalCharityTrackerDataSet5.DataSetName = "FinalCharityTrackerDataSet5";
            this.finalCharityTrackerDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            this.eventBindingSource.DataSource = this.finalCharityTrackerDataSet5;
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.eventBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(560, 70);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Name";
            series1.XValueMember = "Name";
            series1.YValueMembers = "Participants_No";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(649, 547);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Name";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Event_Organizer_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 745);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.max_participants);
            this.Controls.Add(this.max_cost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Event_Organizer_Report";
            this.Text = "Event_Organizer_Report";
            this.Load += new System.EventHandler(this.Event_Organizer_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalCharityTrackerDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label max_cost;
        private System.Windows.Forms.Label max_participants;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FinalCharityTrackerDataSet5 finalCharityTrackerDataSet5;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private FinalCharityTrackerDataSet5TableAdapters.EventTableAdapter eventTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}