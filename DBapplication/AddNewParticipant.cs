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
    public partial class AddNewParticipant : Form
    {
        Controller controllerObj;
        int EmployeeID;
        string PhoneN;
        string ftype;
        int ParticipantID;
        public AddNewParticipant(int id,string phonenum,string typeform)
        {
            controllerObj = new Controller();
            EmployeeID = id;
            PhoneN = phonenum;
            InitializeComponent();
            Phone.Text = PhoneN;
            ftype = typeform;
            
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddNewParticipant_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GenerateParticipantID();
            ParticipantID = Convert.ToInt32(dt.Rows[0][0]);
            ParticipantID += 1;
            if (FName.Text == "" || MName.Text == "" || LName.Text == "" || Phone.Text == "" || (Female.Checked == false && Male.Checked == false) || Address.Text == "" || Email.Text == "")
            {
                MessageBox.Show("Missing Data !");
                return;
            }
            if (Phone.TextLength!=11)
            {
                MessageBox.Show("Incorrect Phone Number, Try Again.");
                return;
            }
            string gender;
            if (Female.Checked)
                gender = "F";
            else
                gender = "M";
            int r = controllerObj.InsertParticipant(ParticipantID, FName.Text, MName.Text, LName.Text, Phone.Text, Convert.ToInt32(participantAge.Value), gender, Address.Text, Email.Text);
            if (r == 0)
                MessageBox.Show("Insertion Failed!");
            else
            {
                MessageBox.Show("Inserted Successfully !");
                if (ftype == "food")
                {
                    AddFood a = new AddFood(EmployeeID,PhoneN);
                    a.Show();
                }
                else if (ftype == "books")
                {
                    AddBook a = new AddBook(EmployeeID,PhoneN);
                    a.Show();
                }
                else if (ftype == "blood")
                {
                    AddBlood a = new AddBlood(EmployeeID,PhoneN);
                    a.Show();
                }
                else if (ftype == "clothes")
                {
                    AddClothes a = new AddClothes(EmployeeID,PhoneN);
                    a.Show();
                }

                else if(ftype=="money")
                {
                    AddMoney a = new AddMoney(EmployeeID,PhoneN);
                    a.Show();
                }
                else
                {
                    controllerObj.InsertVolunteer(Convert.ToInt32(ftype), ParticipantID);
                    MessageBox.Show("Volunteer Added To Event Successfully");
                    Event_Organizing_Dep a = new Event_Organizing_Dep(EmployeeID);
                    a.Show();
                }
                
                this.Hide();
            }
                }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (ftype == "food")
            {
                Food_Dep a = new Food_Dep(EmployeeID);
                a.Show();
                
            }
            else if (ftype == "books")
            {
                Books_Dep a = new Books_Dep(EmployeeID);
                a.Show();
              
            }
            else if (ftype == "blood")
            {
                Blood_Dep a = new Blood_Dep(EmployeeID);
                a.Show();
                
            }
            else if (ftype == "clothes")
            {
                Cloths_Dep a = new Cloths_Dep(EmployeeID);
                a.Show();
               
            }
            else if(ftype=="money")
            {
                Money_Donations_Dep a = new Money_Donations_Dep(EmployeeID);
                a.Show();
                
            }
            else if(ftype=="event")
            {
                Event_Organizing_Dep a = new Event_Organizing_Dep(EmployeeID);
                a.Show();
                
            }
            this.Hide();
        }
    }
}
