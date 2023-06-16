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
    public partial class ViewEvents : Form
    {
        Controller controllerObj;
        int EmployeeID;
        int EventID;
        public ViewEvents(int employeeid)
        {
            EmployeeID = employeeid;
            controllerObj = new Controller();
            InitializeComponent();
            eventName.DataSource = controllerObj.SelectEventName();
            eventName.DisplayMember = "Name";
            eventName.SelectedIndex = -1;
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void eventName_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventDate.Enabled = true;
            eventDate.DataSource = controllerObj.SelectDateByEventName(eventName.Text);
            eventDate.DisplayMember = "date";
           
        }

        private void eventDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.EventByNameAndDate(eventName.Text, eventDate.Text);
            numP.Text = dt.Rows[0][0].ToString();
            statusBox.Text = dt.Rows[0][1].ToString();
            EventID =Convert.ToInt32(dt.Rows[0][2].ToString());
            DataTable dt2 = controllerObj.SelectParticipantCount(EventID);
            int countP =Convert.ToInt32(dt2.Rows[0][0] );
            int remainingP = Convert.ToInt32(numP.Text)-countP;
            remainingPlaces.Text = remainingP.ToString();
            if (remainingP>0 && statusBox.Text!="Done")
            {
                addVolunteer.Enabled = true;
            }
        }

        private void statusBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Event_Organizing_Dep ev = new Event_Organizing_Dep(EmployeeID);
            ev.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addVolunteer_Click(object sender, EventArgs e)
        {

            SearchParticipant s = new SearchParticipant(EmployeeID, EventID.ToString() );
            s.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void ViewEvents_Load(object sender, EventArgs e)
        {

        }
    }
}
