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
    public partial class Change_Password : Form
    {
        Controller controllerObj;
        public Change_Password()
        {
            InitializeComponent();
            controllerObj = new Controller();   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome w = new welcome();
            w.Show();
        }

        private void next_Click(object sender, EventArgs e)
        {
            
            bool found = false;
            DataTable dt = controllerObj.SelectAllUsers();
            if(UserName_TextBox.Text==""||Password_TextBox.Text=="")
            {
                MessageBox.Show("Password and UserName are required");
            }
            foreach (DataRow row in dt.Rows)
            {
                if (UserName_TextBox.Text == row[3].ToString() && Password_TextBox.Text == row[1].ToString())
                {
                    found = true;
                    break;
                }
            }
            if(found)
            {
                this.Hide();
                Change_Password_2  c = new Change_Password_2(Password_TextBox.Text,UserName_TextBox.Text);
              
                c.Show();

            }
            else
                MessageBox.Show("User Not found ");

        }

        private void Change_Password_Load(object sender, EventArgs e)
        {
        }
    }
}
