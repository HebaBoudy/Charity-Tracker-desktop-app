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

    public partial class AddBook : Form
    {
        int flagother;
        int Employee_ID;
        Controller controllerObj;
        string PhoneNum;
        public AddBook(int Employee_id, string phonenum)
        {
            Employee_ID = Employee_id;
            PhoneNum = phonenum;
            InitializeComponent();
            controllerObj = new Controller();



        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            int id;
            int atOff = 0;
            int donorID;

            DataTable dt = controllerObj.GenerateBookID();
            if (dt.Rows[0][0].ToString() != "")
            {
                id = Convert.ToInt32(dt.Rows[0][0]);
                id = id + 1;
            }
            else
                id = 1;


            if (BNameTxtbx.Text == "" || Subjecttxt.Text == "" || stage_combobx.Text == "" || Term_combobx.Text == "" || year_combobx.Text == "")
            {
                MessageBox.Show("Fill ALL fields !");
                return;
            }

            if (checkBox1.Checked == true)
                atOff = 1;


            donorID = Convert.ToInt32(controllerObj.SelectParticipantIDByPhoneNumber(PhoneNum).Rows[0][0].ToString());
            string EduYear = stage_combobx.Text + " " + year_combobx.Text + " " + Term_combobx.Text;
            if (flagother == 1)
            {
                EduYear = null;
            }

            int flag = controllerObj.InsertBook(id, BNameTxtbx.Text, atOff, dateTimePicker1.Text, Convert.ToInt32(Quantity.Value), EduYear, Subjecttxt.Text, Employee_ID, donorID);
            if (flag == 0)
                MessageBox.Show("Insertion Failed!");
            else
            {
                MessageBox.Show("Insertion Done :)");
                DataTable dtt = controllerObj.CheckBookInStock(BNameTxtbx.Text, EduYear, Subjecttxt.Text);

                if (dtt != null)
                {
                    controllerObj.AddBookQuantity(BNameTxtbx.Text, Convert.ToInt32(Quantity.Value), EduYear, Subjecttxt.Text);
                }
                else
                    controllerObj.InsertBookInStock(BNameTxtbx.Text, Convert.ToInt32(Quantity.Value), EduYear, Subjecttxt.Text);
            }



        }


        private void stage_combobx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stage_combobx.Text == "Primary")
            {
                year_combobx.Enabled = true;
                Term_combobx.Enabled = true;
                year_combobx.DataSource = new string[] { "First", "Second", "Third", "Fourth", "Fifth", "Sixth" };
                flagother = 0;
            }
            if (stage_combobx.Text == "Prepratory" || stage_combobx.Text == "Secondary")
            {
                year_combobx.Enabled = true;
                Term_combobx.Enabled = true;
                year_combobx.DataSource = new string[] { "First", "Second", "Third" };
                flagother = 0;
            }
            if (stage_combobx.Text == "Other")
            {
                year_combobx.Enabled = false;
                Term_combobx.Enabled = false;
                flagother = 1;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Books_Dep b = new Books_Dep(Employee_ID);
            b.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Books_Dep b = new Books_Dep(Employee_ID);
            b.Show();
            this.Close();
        }

        private void addPt_Click(object sender, EventArgs e)
        {




        }

        private void addPtButton_Click(object sender, EventArgs e)
        {

        }
    }
}