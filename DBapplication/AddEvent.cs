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
    public partial class AddEvent : Form
    {
        int EmployeeID;
        Controller controllerObj;
        public AddEvent(int id)
        {
            InitializeComponent();
            EmployeeID = id;
            controllerObj = new Controller();
            comboBox1.DataSource = controllerObj.SelectAllEstablishments();
            comboBox1.DisplayMember = "Name";
            comboBox1.Enabled = false;
            
        }

        private void addEventB_Click(object sender, EventArgs e)
        {
            int id;
            int visit = 0;
            int supervisorID;
            
            DataTable dt = controllerObj.GenerateEventID();
            if (dt.Rows[0][0].ToString() != "")
            {
                id = Convert.ToInt32(dt.Rows[0][0]);
                id = id + 1;
            }
            else
                id = 1;

            if (checkBox1.Checked == true)
            {
                visit = 1;
               
            }

            if (name.Text == "" || phone.Text == "" || cost.Value.ToString() == "" || pNum.Value.ToString() == "" || numericUpDown1.Value.ToString() == "")
            {
                MessageBox.Show("Please Fill all data");
                return;
            }
            if (phone.TextLength != 11)
            {
                MessageBox.Show("Invalid Phone Number");
                return;
            }
            DataTable dt2 = controllerObj.SelectEmployeesByPhoneNumber(phone.Text);

            if (dt2==null)
            {
                MessageBox.Show("Employee doesn't exist, please enter valid phone number");
                return;
            }
            else
                supervisorID = Convert.ToInt32(dt2.Rows[0][0].ToString());

            DataTable dt3 = controllerObj.isExistingEvent(name.Text, dateTimePicker1.Text);
            if(dt3==null)
            {

                int r = controllerObj.InsertEvent(id, visit, name.Text, Convert.ToInt32(cost.Value), Convert.ToInt32(pNum.Value), supervisorID, "Upcoming", dateTimePicker1.Text, Convert.ToInt32(numericUpDown1.Value));
                if (r == 0)
                {
                    MessageBox.Show("Insertion Failed!");
                    return;
                }
                else
                {
                    MessageBox.Show("Event Added Successfully");
                    if (checkBox1.Checked == true)
                    {
                        controllerObj.InsertVisit(id, comboBox1.Text);
                        controllerObj.SubtractFromAmount(Convert.ToInt32(cost.Value));
                    }
                    else
                    {
                        controllerObj.InsertNonVisit(id, eventLocation.Text);
                    }
                    return;
                }
            }
            else
            {
                MessageBox.Show("Insertion Failed ,Event Already Exists");
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Event_Organizing_Dep ev = new Event_Organizing_Dep(EmployeeID);
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox1.Enabled = true;
                eventLocation.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = false;
                eventLocation.Enabled = true;
            }
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {

        }
    }
}
