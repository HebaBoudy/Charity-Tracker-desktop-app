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
    public partial class AddClothes : Form
    {
        int Employee_ID;
        Controller controllerObj;
        string PhoneNum;
       
        public AddClothes(int id,string phonenum)
        {
            Employee_ID = id;
            PhoneNum = phonenum;
            InitializeComponent();
            controllerObj = new Controller();
            clothType.SelectedIndex = -1;


        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cloths_Dep c = new Cloths_Dep(Employee_ID);
            c.Show();
            this.Hide();
        }

      

        private void addC_Click(object sender, EventArgs e)
        {
            int id;
            int atOff = 0;
            int donorID;
            DataTable dt = controllerObj.GenerateClothesID();
            if (dt.Rows[0][0].ToString()!="")
            {
                id =Convert.ToInt32(dt.Rows[0][0].ToString());
                id += 1;
            }
            else id = 1;
          
            if(clothType.Text==""||sizeCombobox.Text=="")
            {
                MessageBox.Show("Please Fill All Fields !");
                return;
            }
            if(!Male.Checked && !Female.Checked)
            {
                MessageBox.Show("Please Select Gender !");
            }
           
            if (checkBox1.Checked)
                atOff = 1;
           
            
                donorID = Convert.ToInt32(controllerObj.SelectParticipantIDByPhoneNumber(PhoneNum).Rows[0][0].ToString());
                string gender;
                if (Female.Checked)
                    gender = "F";
                else
                    gender = "M";
                int r = controllerObj.InsertClothes(id, sizeCombobox.Text, gender, Convert.ToInt32(numericUpDown1.Value), dateTimePicker1.Text, atOff, clothType.Text, Employee_ID, donorID);
                if (r == 0)
                    MessageBox.Show("Insertion Failed!");
            else
            {
                MessageBox.Show("Inserted Successfully");
                DataTable dtt = controllerObj.CheckClothesInStock(clothType.Text, sizeCombobox.Text, gender);
                if (dtt != null)
                {
                    controllerObj.AddClothesQuantity(clothType.Text, sizeCombobox.Text, gender, Convert.ToInt32(numericUpDown1.Value));
                }
                else
                {
                    controllerObj.InsertClothesInStock(clothType.Text, sizeCombobox.Text, gender, Convert.ToInt32(numericUpDown1.Value));
                }

            }
        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cloths_Dep c = new Cloths_Dep(Employee_ID);
            c.Show();
            this.Close();
        }

        private void addP_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Cloths_Dep c = new Cloths_Dep(Employee_ID);
            c.Show();
            this.Hide();
        }
    }
}
