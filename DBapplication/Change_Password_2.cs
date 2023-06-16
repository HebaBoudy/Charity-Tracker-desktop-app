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
    public partial class Change_Password_2 : Form
    {
        string OldPass,UserName;
        Controller controllerObj;
        public Change_Password_2(string oldpass,string username)
        {
            controllerObj=new Controller();
            InitializeComponent();
            OldPass = oldpass;
            UserName = username;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Change_Password p =new Change_Password();
            this.Hide();
            p.ShowDialog();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if(new_password_textbox.Text ==""|| confirm_password_text_box.Text=="")
            {
                MessageBox.Show("Please Fill the two required Fields");
                return;
            }
            if (new_password_textbox.Text !=confirm_password_text_box.Text)
            {
                MessageBox.Show("Please confirm your new password corretly !");
                return;
            }else 
            {
               // DataTable dt = controllerObj.IsPasswordExists(new_password_textbox.Text);
               // if (dt == null)
              //  {
                    int x = controllerObj.ChangePassword(new_password_textbox.Text,UserName);
                    if (x == 0)
                    {
                        MessageBox.Show("Failed to change");
                    }
                    else
                    {
                        MessageBox.Show("Password Updated Successfully!");
                    }
              //  }
               // else
                   // MessageBox.Show("This password already exist, Try another One ");

            }
            
        }
    }
}
