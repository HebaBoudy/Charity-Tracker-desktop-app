using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Managerial_Reports : Form
    {
        Controller obj;
        public Managerial_Reports()
        {
            InitializeComponent();
            obj = new Controller();
        }

        private void Managerial_Reports_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            DataSet1 d = new DataSet1();//esm el dataset
            DataSet2 d2 = new DataSet2();
            string cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=FinalCharityTracker;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter("select Amount, Donation_date, Destination From Money_Donations", cn);//el query
            SqlDataAdapter da2 = new SqlDataAdapter("select  Name , Cost , Date From Event", cn);
            da.Fill(d, d.Tables[0].TableName);//eda?
           da2.Fill(d2, d2.Tables[0].TableName);
           ReportDataSource rds2 = new ReportDataSource("Events_Costs", d2.Tables[0]);
            ReportDataSource rds = new ReportDataSource("Money_Donations", d.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
            DataTable dt2 = obj.GetCurrentBalance();
            current_balance.Text = dt2.Rows[0][0].ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            managerial_report2 m = new managerial_report2();
            this.Hide();
            m.Show();
        }
    }
}
