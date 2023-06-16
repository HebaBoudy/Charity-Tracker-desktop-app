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
    public partial class AddBus : Form
    {
        int EmployeeID;
        Controller controllerObj;
        int EventID;
        int DriverID;
        public AddBus(int empID)
        {
            controllerObj = new Controller();
            EmployeeID = empID;
            InitializeComponent();
            eventDate.Enabled = false;
            eventName.DataSource = controllerObj.SelectVisitName();
            eventName.DisplayMember = "Name";
          
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Event_Organizing_Dep ev = new Event_Organizing_Dep(EmployeeID);
            ev.Show();
            this.Hide();
        }

        private void eventDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectVisitByNameAndDate(eventName.Text, eventDate.Text);
            numP.Text = dt.Rows[0][0].ToString();
            EventID = Convert.ToInt32(dt.Rows[0][1].ToString());
        }

        private void eventName_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventDate.Enabled = true;
            eventDate.DataSource = controllerObj.SelectVisitDateByEventName(eventName.Text);
            eventDate.DisplayMember = "date";
           
            busID.DataSource = controllerObj.SelectBusses();
            busID.DisplayMember = "ID";
          
        }

        private void addbustoevent_Click(object sender, EventArgs e)
        {
            if(eventName.Text==""|| eventDate.Text == "" || busID.Text == "" || driverPhoneNum.Text == "" )
            {
                MessageBox.Show("Please Enter All Data");
                return;
            }
            if(driverPhoneNum.TextLength!=11)
            {
                MessageBox.Show("Please Enter Valid Phone Number");
                return;
            }
            if(Convert.ToInt32(numP.Text)> Convert.ToInt32(capacity.Text))
            {
                MessageBox.Show("Bus Capacity Not Enough ");
                return;
            }
            DataTable dt = controllerObj.SelectEmployeesByPhoneNumber(driverPhoneNum.Text);
            if (Convert.ToInt32(dt.Rows[0][8].ToString())!=7)
            {
                MessageBox.Show("Employee is not a driver,Please Enter Valid Phone Number");
                return;
            }
            else
            
               DriverID = Convert.ToInt32(dt.Rows[0][0].ToString());
            int r = controllerObj.AddBusToEvent(DriverID, EventID, Convert.ToInt32(busID.Text));
            if(r==0)
            {
                MessageBox.Show("Insertion Failed");
                return;
            }
            else
            {
                MessageBox.Show("Bus Added To Visit Successfully");
                return;
            }

        }

        private void numP_TextChanged(object sender, EventArgs e)
        {

        }

        private void busID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectBusByID(Convert.ToInt32(busID.Text));
            capacity.Text = dt.Rows[0][0].ToString();
        }
    }
}
