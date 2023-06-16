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
    public partial class SearchParticipant : Form
    {
        int Employee_ID;
        string ftype;
        Controller controllerObj;
        public SearchParticipant(int id, string formtype)
        {
            Employee_ID = id;
            ftype = formtype;
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (ftype=="food")
            {
                Food_Dep f = new Food_Dep(Employee_ID);
                f.Show();
            }
            else if (ftype == "books")
            {
                Books_Dep b = new Books_Dep(Employee_ID);
                b.Show();
            }
            else if (ftype == "blood")
            {
                Blood_Dep bd = new Blood_Dep(Employee_ID);
                bd.Show();
            }
            else if (ftype == "clothes")
            {
                Cloths_Dep c = new Cloths_Dep(Employee_ID);
                c.Show();
            }
            else if(ftype=="money")
            {
                Money_Donations_Dep m = new Money_Donations_Dep(Employee_ID);
                m.Show();
            }
            else 
            {
                Event_Organizing_Dep ev = new Event_Organizing_Dep(Employee_ID);
                ev.Show();
            }

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Please enter phone number");
                return;
            }
            if(textBox1.TextLength!=11)
            {
                MessageBox.Show("Please enter valid phone number");
                return;
            }
            if (controllerObj.SelectParticipantIDByPhoneNumber(textBox1.Text)==null)
            {
                MessageBox.Show("No Participant was found, please add");

                AddNewParticipant a = new AddNewParticipant(Employee_ID, textBox1.Text, ftype);
                a.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Participant Found!");
                if (ftype == "food")
                {
                    AddFood a = new AddFood(Employee_ID,textBox1.Text);
                    a.Show();
                    this.Hide();
                }
                else if (ftype == "books")
                {
                    AddBook a = new AddBook(Employee_ID,textBox1.Text);
                    a.Show();
                    this.Hide();
                }
                else if (ftype == "blood")
                {
                    AddBlood a = new AddBlood(Employee_ID,textBox1.Text);
                    a.Show();
                    this.Hide();
                }
                else if (ftype == "clothes")
                {
                    AddClothes a = new AddClothes(Employee_ID,textBox1.Text);
                    a.Show();
                    this.Hide();
                }
               
                else if (ftype=="money")
                {
                    AddMoney a = new AddMoney(Employee_ID, textBox1.Text);
                    a.Show();
                    this.Hide();
                
                }
              
            }
        }
    }
}
