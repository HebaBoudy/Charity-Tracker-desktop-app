using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBapplication
{
    public partial class welcome : Form
    {
        Controller controllerObj;
        public welcome()
        {
            InitializeComponent();
            controllerObj=new Controller(); 
        }
        int Employee_id;
        int Dep_ID;
        bool HeadFlag = false;
        bool food_dep = false;
        bool blood_dep = false;
        bool cloths_dep = false;
        bool books_dep = false;
        bool event_organizing_dep = false;
        bool money_Donations_Dep = false;
        bool transportation_dep = false;
        //int j = BitConverter.ToInt32(Guid.NewGuid().ToByteArray(), 0);
        DataTable dt = new DataTable();
        private void txtbxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void welcome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             HeadFlag = false;
             food_dep = false;
             blood_dep = false;
             cloths_dep = false;
             books_dep = false;
             event_organizing_dep = false;
             money_Donations_Dep = false;
             transportation_dep = false;

            if (txtbxpassword.Text == "" || txtbxUserName.Text == "")
            {
                MessageBox.Show("Both  ID and password are required !");
                return;
            }
            
            dt = controllerObj.SelectAllUsers();
            
            foreach (DataRow row in dt.Rows)
            {
                if (row[3].ToString() == txtbxUserName.Text && row[1].ToString() == txtbxpassword.Text)
                {
                    Employee_id = Convert.ToInt32(row[0]);
                    Dep_ID =Convert.ToInt32( row[2]);
                   switch (Dep_ID)
                    {
                        case 1:
                            HeadFlag = true; break;
                        case 2:
                            food_dep=true;  break;
                        case 3:blood_dep=true; break;
                        case 4:
                            money_Donations_Dep=true; break;
                        case 5: books_dep=true; break;
                        case 6: cloths_dep=true; break;
                        
                        case 9:
                            event_organizing_dep=true; break;
                    }
                   
                }
            }
           
             if (HeadFlag)
            {
                AdminProvidedFunctionalities x = new AdminProvidedFunctionalities(Employee_id);
                x.Show();
            }
            else if(food_dep)
            {
               Food_Dep f=new Food_Dep(Employee_id);   
                f.Show();
            }
            else if(blood_dep)
            {
                Blood_Dep b=new Blood_Dep(Employee_id);
                b.Show();

            }
            else if(money_Donations_Dep)
            {
                Money_Donations_Dep m=new Money_Donations_Dep(Employee_id);    
                m.Show();
            }
            else if(books_dep)
            {
                Books_Dep b=new Books_Dep(Employee_id);
                b.Show();
            }
            else if(cloths_dep)
            {
                Cloths_Dep c=new Cloths_Dep(Employee_id);
                c.Show();
            }
            
            else if(event_organizing_dep)
            {
                Event_Organizing_Dep d =new Event_Organizing_Dep(Employee_id);
                d.Show();   
            }
            else 
            {
                MessageBox.Show("Invalid User ID or  Department ID , Please try again !");
                 
            }
            //this.Hide();

        }

        private void Change_Password_Click(object sender, EventArgs e)
        {
            Change_Password p = new Change_Password();
            this.Hide();
            p.Show();
        }
    }
}
