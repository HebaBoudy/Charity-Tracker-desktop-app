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
    public partial class UpdateEvent : Form
    {
        int EmployeeID;
        Controller controllerObj;
        public UpdateEvent(int id)
        {
            EmployeeID = id;
            InitializeComponent();
            controllerObj = new Controller();
            UpdateButton.Enabled = false;
            button1.Enabled = false;
            eventName.DisplayMember = "Name";
            eventName.SelectedIndex = -1;
            eventName.DataSource = controllerObj.SelectEventName();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Event_Organizing_Dep ev = new Event_Organizing_Dep(EmployeeID);
            this.Hide();

            ev.Show();
        }

        private void eventName_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventDate.Enabled = true;
            eventDate.DataSource = controllerObj.SelectDateByEventName(eventName.Text);
            eventDate.DisplayMember = "date";
        }

        private void eventDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
            DataTable dt = controllerObj.SelectEventByNameAndDate(eventName.Text, eventDate.Text);
            if (dt == null)
            {
                MessageBox.Show("Event doesn't exist");
                return;
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            UpdateButton.Enabled = true;
            button1.Enabled = true;
        }

        private void UpdateEvent_Load(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)

        {

            int x=2, y=2, z=2, a=2;
           if (eventName.Text==""||eventDate.Text=="")
            {
                MessageBox.Show("Please Select an Event and Date");
                return;
            }
     

            if(eventCost.Value!=0)
            {
                x = controllerObj.UpdateEventCost(eventName.Text, eventDate.Text,Convert.ToInt32( eventCost.Value));
                if (x == 0)
                    MessageBox.Show("Cost Update Failed");
            }
            if(newStatus.Text!="")
            {
                y = controllerObj.UpdateEventStatus(eventName.Text, eventDate.Text,newStatus.Text);
                if (y==0)
                    MessageBox.Show("Status Update Failed");
            }
            if(duration.Value!=0)
            {
                z = controllerObj.UpdateEventCost(eventName.Text, eventDate.Text, Convert.ToInt32(duration.Value));
                if (z == 0)
                    MessageBox.Show("Duration Update Failed");
            }
            if(newPhoneNum.Text!="")
            {
                if(newPhoneNum.TextLength!=11)
                {
                    MessageBox.Show("Please Enter valid phone number");
                    return;
                }
                DataTable dt = controllerObj.SelectEmployeesByPhoneNumber(newPhoneNum.Text);
                if (dt==null)
                {
                    MessageBox.Show("Employee does not exist, please enter valid phone number");
                    return;
                }
                else
                {
                    int employeeid =Convert.ToInt32(dt.Rows[0][0]);
                    a = controllerObj.UpdateEventSupervisor(eventName.Text, eventDate.Text, employeeid);
                    if (a==0)
                    {
                        MessageBox.Show("Supervisor Update Failed");
                    }
                }
                
            }
            

            if(a!=0&&x!=0&& y != 0 && z != 0)
            {
                MessageBox.Show("Selected fields updated successfully");
                DataTable dt =controllerObj.SelectEventByNameAndDate(eventName.Text, eventDate.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
   
                eventName.SelectedIndex = -1;
                eventName.Refresh();
                UpdateButton.Enabled = false;
                button1.Enabled = false;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = controllerObj.DeleteEventByNameandDate(eventName.Text, eventDate.Text);
            if (x == 0)
                MessageBox.Show("Deletion Failed");
            else
            {
                MessageBox.Show("Event Deleted Successfully");
                UpdateButton.Enabled = false;
                button1.Enabled = false;
            }
        }
    }
}
