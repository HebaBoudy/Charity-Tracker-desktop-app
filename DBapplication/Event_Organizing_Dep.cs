using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Event_Organizing_Dep : Form
    {
        int EmployeeID;
        public Event_Organizing_Dep(int Employee_ID)
        {
            EmployeeID = Employee_ID;
            InitializeComponent();
        }

        private void Event_Organizing_Dep_Load(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            welcome w = new welcome();
            w.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewEvents v = new ViewEvents(EmployeeID);
            v.Show();
            this.Hide();
        }

        private void addEventB_Click(object sender, EventArgs e)
        {
            AddEvent addE = new AddEvent(EmployeeID);
            addE.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchParticipant s = new SearchParticipant(EmployeeID, "event");
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewVolunteers v = new ViewVolunteers(EmployeeID);
            v.Show();
            this.Close();

        }

        private void updateEvent_Click(object sender, EventArgs e)
        {
            UpdateEvent u = new UpdateEvent(EmployeeID);
            u.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addbustoevent_Click(object sender, EventArgs e)
        {
            AddBus a = new AddBus(EmployeeID);
            a.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Event_Organizer_Report o = new Event_Organizer_Report();
            this.Hide();
            o.Show();
        }
    }
}
