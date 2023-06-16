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
    public partial class AddFood : Form
    {
        int Employee_ID;
        Controller controllerObj;
        string PhoneNum;
        public AddFood(int id, string phonenum)
        {
            Employee_ID = id;
            PhoneNum = phonenum;
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Food_Dep f = new Food_Dep(Employee_ID);
            f.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Food_Dep f = new Food_Dep(Employee_ID);
            f.Show();
            this.Close();
        }

        private void AddFood_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;

            int donorID;
            DataTable dt = controllerObj.GenerateFoodID();
            if (dt.Rows[0][0].ToString() != "")
            {
                id = Convert.ToInt32(dt.Rows[0][0].ToString());
                id += 1;
            }

            else id = 1;

            if (FoodType.Text == "")
            {
                MessageBox.Show("Please enter all data");
                return;

            }

            donorID = Convert.ToInt32(controllerObj.SelectParticipantIDByPhoneNumber(PhoneNum).Rows[0][0].ToString());


            int r = controllerObj.InsertFood(id, FoodType.Text, Convert.ToInt32(numericUpDown1.Value), donationdate.Text, expirydate.Text, Employee_ID, donorID);
            if (r == 0)
                MessageBox.Show("Insertion Failed!");
            else
            {
                MessageBox.Show("Inserted Successfully");
                DataTable dtt = controllerObj.CheckFoodsInStock(FoodType.Text);
                if (dtt != null)
                {
                    controllerObj.AddFoodQuantity(FoodType.Text, Convert.ToInt32(numericUpDown1.Value));
                }
                else
                {
                    controllerObj.InsertFoodInStock(FoodType.Text, Convert.ToInt32(numericUpDown1.Value));
                }



            }

        }


    }
}