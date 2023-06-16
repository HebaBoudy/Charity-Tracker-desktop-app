using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class managerial_report2 : Form
    {
        public managerial_report2()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void managerial_report2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalCharityTrackerDataSet9.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.finalCharityTrackerDataSet9.Employee);

        }

        //private void managerial_report2_Load(object sender, EventArgs e)
        //{
        //    this.employeeTableAdapter.Fill(this.finalCharityTrackerDataSet7.Employee);
        //    // TODO: This line of code loads data into the 'finalCharityTrackerDataSet8.Statistics' table. You can move, or remove it, as needed.
        //  //  this.statisticsTableAdapter.Fill(this.finalCharityTrackerDataSet8.Statistics);
        //    // TODO: This line of code loads data into the 'finalCharityTrackerDataSet7.Employee' table. You can move, or remove it, as needed.


        //}

    }
}
