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
    public partial class AddMoney : Form
    {
        int Employee_ID;
        Controller controllerObj;
        string PhoneNum;
        public AddMoney(int empid,string phone)
        {
            InitializeComponent();
            controllerObj = new Controller();
            Employee_ID = empid;
            PhoneNum = phone;
            comboBox1.DataSource = controllerObj.SelectAllEstablishments();
            comboBox1.DisplayMember = "Name";
        }

        private void AddMoney_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Money_Donations_Dep f = new Money_Donations_Dep(Employee_ID);
            f.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;

            int donorID;
            DataTable dt = controllerObj.GenerateMoneyID();
            if (dt.Rows[0][0].ToString() != "")
            {
                id = Convert.ToInt32(dt.Rows[0][0].ToString());
                id += 1;
            }

            else id = 1;
            int atoffice=0;
            if (checkBox1.Checked == true)
                atoffice = 1;

            donorID = Convert.ToInt32(controllerObj.SelectParticipantIDByPhoneNumber(PhoneNum).Rows[0][0].ToString());
            int r = controllerObj.InsertMoney(id,dateTimePicker1.Text,Convert.ToInt32( numericUpDown1.Value),comboBox1.Text,atoffice,Employee_ID,donorID);
            if (r == 0)
                MessageBox.Show("Insertion Failed!");
            else
            {
                MessageBox.Show("Inserted Successfully");
                controllerObj.UpdateDonations(comboBox1.Text,Convert.ToInt32( numericUpDown1.Value));
            }
        }
    }
}
