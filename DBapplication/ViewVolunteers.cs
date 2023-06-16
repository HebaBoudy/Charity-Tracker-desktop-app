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
    public partial class ViewVolunteers : Form
    {
        int EmployeeID;
        Controller controllerObj;
        public ViewVolunteers(int EmpID)
        {
            EmployeeID = EmpID;
            controllerObj = new Controller();
            InitializeComponent();
            eventNameSearch.ValueMember = "ID";
            eventNameSearch.DisplayMember = "Name";
            eventNameSearch.DataSource = controllerObj.SelectAllEvents();
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Event_Organizing_Dep ev = new Event_Organizing_Dep(EmployeeID);
            ev.Show();
            this.Close();
        }

        private void eventName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllVolunteersInEvent(Convert.ToInt32(eventNameSearch.SelectedValue.ToString()));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
