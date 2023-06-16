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
    public partial class AddNewEstablishment : Form
    {
        int handler_id;
        Controller controllerobj;
        public AddNewEstablishment(int employee)
        {
            handler_id = employee;
            controllerobj = new Controller();
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (EstablishmentName.Text=="" || Phone.Text=="")
            {
                MessageBox.Show("Please Enter Name and Phone Number!!");
            }
            else if(Phone.TextLength != 11)
            {
                MessageBox.Show("Please Enter a valid Phone Number!!");
            }
            else
            {
               int a=  controllerobj.AddEstablishment(EstablishmentName.Text, Phone.Text, BankAccount.Text, Email.Text, 0, 0, Location.Text);
                if (a==0)
                {
                    MessageBox.Show("Failed to insert ");
                }
                else
                {
                    MessageBox.Show("Inserted successfully!!");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Establishments E = new Establishments(handler_id);
            this.Hide();
            E.Show();
        }
    }
}
