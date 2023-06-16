using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DBapplication
{
    public partial class Event_Organizer_Report : Form
    {
        Controller obj;
        
        public Event_Organizer_Report()
        {
            obj = new Controller();
            InitializeComponent();
        }

        private void Event_Organizer_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalCharityTrackerDataSet5.Event' table. You can move, or remove it, as needed.
            this.eventTableAdapter.Fill(this.finalCharityTrackerDataSet5.Event);
            // TODO: This line of code loads data into the 'finalCharityTrackerDataSet3.Non_Visit' table. You can move, or remove it, as needed.
            //  this.non_VisitTableAdapter1.Fill(this.finalCharityTrackerDataSet3.Non_Visit);
            // TODO: This line of code loads data into the 'finalCharityTrackerDataSet2.Non_Visit' table. You can move, or remove it, as needed.
            //   this.non_VisitTableAdapter.Fill(this.finalCharityTrackerDataSet2.Non_Visit);
            DataTable d = obj.GetNameOfMaxParticipantsEvent();
            DataTable dt2 = obj.GetNameOfHighestCostEvent();

           
            max_cost.Text = dt2.Rows[0][0].ToString();
            max_participants.Text = d.Rows[0][0].ToString();

            this.reportViewer1.RefreshReport();
           

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            DataSet3 d = new DataSet3();//esm el dataset
            string cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=FinalCharityTracker;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cs);
            SqlDataAdapter da2 = new SqlDataAdapter("select  event.Name , Cost , Participants_No  From Event ,Employee where Supervisor_ID=Employee.ID", cn);
            da2.Fill(d, d.Tables[0].TableName);//eda?
      
            ReportDataSource rds = new ReportDataSource("DataSetEvent", d.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
            //  chart1.Series["Visits_Non_Visits"].Points.
            //   pichart();
           // using (FinalCharityTrackerEntities db = new FinalCharityTrackerEntities())
             //   chart1.Series.["ID"].add
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        //private void pichart()
        //{
        //   // throw new NotImplementedException();
        //}

        //private void chart1_Click(object sender, EventArgs e)
        //{

        //        DataTable dt = obj.GetCountOfNonVisits();
        //    chart1.DataSource = Convert.ToInt32(dt.Rows[0][0]);
        //    chart1.Refresh();
        //}
    }
}
