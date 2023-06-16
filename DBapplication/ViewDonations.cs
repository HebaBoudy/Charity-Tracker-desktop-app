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
    public partial class ViewDonations : Form
    {
        string formtype;
        Controller controllerObj;
        int EmployeeID;
        public ViewDonations(int empid,string ftype)
        {
            InitializeComponent();
            controllerObj = new Controller();
            EmployeeID = empid;
            formtype = ftype;
            if(formtype=="blood")
            {
                donationType.Text = "Blood";
                comboBox1.Items.Add("Blood Type");
             //   comboBox1.Items.Add("Expiry Date");
            }
            else if(formtype=="food")
            {
                donationType.Text = "Food";
                comboBox1.Items.Add("Food Type");
               // comboBox1.Items.Add("Expiry Date");
            }
            else if (formtype == "clothes")
            {
                donationType.Text = "Clothes";
                comboBox1.Items.Add("Type");
                comboBox1.Items.Add("Size");
                comboBox1.Items.Add("Gender");

            }
            else if (formtype == "books")
            {
                donationType.Text = "Books";
                comboBox1.Items.Add("Educational Year");
                comboBox1.Items.Add("Subject");
            }
            else if(formtype=="money")
            {
                donationType.Text = "Money";
                comboBox1.Items.Add("Destination");

            }
            comboBox1.Items.Add("Phone Number");
            comboBox1.Items.Add("Handling Employee");
           // comboBox1.Items.Add("Donation Date");
            comboBox1.Items.Add("All");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Phone Number" || comboBox1.Text == "Handling Employee")
            {
                phonesearch.Visible = true;
                label5.Visible = true;
                comboBox2.Visible = false;
                label6.Visible = false;
            }
            else if (comboBox1.Text == "Donation Date")
            {
                phonesearch.Visible = false;
                label5.Visible = false;
                comboBox2.Visible = true;
                label6.Visible = true;
                label6.Text = "Date";
                comboBox2.DataSource = null;
                comboBox2.Items.Clear();
                comboBox2.DataSource = controllerObj.SelectDistinctDate(formtype);
                comboBox2.DisplayMember = "Donation_date";
            }
            if (formtype == "blood")
            {
                if (comboBox1.Text=="Blood Type")
                {
                    phonesearch.Visible = false;
                    label5.Visible = false;
                    comboBox2.Visible = true;
                    label6.Visible = true;
                    label6.Text = "Type";
                    comboBox2.DataSource = null;
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("A");
                    comboBox2.Items.Add("A-");
                    comboBox2.Items.Add("A+");
                    comboBox2.Items.Add("B");
                    comboBox2.Items.Add("B-");
                    comboBox2.Items.Add("B+");
                    comboBox2.Items.Add("O");
                    comboBox2.Items.Add("O+");
                    comboBox2.Items.Add("O-");
                    comboBox2.Items.Add("AB");
                    comboBox2.Items.Add("AB+");
                    comboBox2.Items.Add("AB-");


                }
                else if(comboBox1.Text=="Expiry Date")
                {
                    phonesearch.Visible = false;
                    label5.Visible = false;
                    comboBox2.Visible=true;
                    label6.Visible = true;
                    label6.Text = "Date";
                    comboBox2.DataSource = null;
                    comboBox2.Items.Clear();
                    comboBox2.DataSource = controllerObj.SelectDistinctExpiry(formtype);
                    comboBox2.DisplayMember = "Expiry_date";
                }
                
                else if(comboBox1.Text=="All")
                {
                    phonesearch.Visible = false;
                    label5.Visible = false;
                    comboBox2.Visible = false;
                    label6.Visible = false;
                }

            }
            else if (formtype == "food")
            {
              if(comboBox1.Text=="Food Type")
                {
                    phonesearch.Visible = false;
                    label5.Visible = false;
                    comboBox2.Visible = true;
                    label6.Visible = true;
                    label6.Text = "Type";
                    comboBox2.DataSource = null;
                    comboBox2.Items.Clear();
                    comboBox2.DataSource = controllerObj.SelectByFoodType();
                    comboBox2.DisplayMember = "Name"; 
                }
              else if(comboBox1.Text=="Expiry Date")
                {
                   
                        phonesearch.Visible = false;
                        label5.Visible = false;
                        comboBox2.Visible = true;
                        label6.Visible = true;
                        label6.Text = "Date";
                        comboBox2.DataSource = null;
                        comboBox2.Items.Clear();
                        comboBox2.DataSource = controllerObj.SelectDistinctExpiry(formtype);
                        comboBox2.DisplayMember = "Expiry_date";
                    
                }

            }
            else if (formtype == "clothes")
            {
               
              if (comboBox1.Text == "Size")
                {
                    phonesearch.Visible = false;
                    label5.Visible = false;
                    comboBox2.Visible = true;
                    label6.Visible = true;
                    label6.Text = "Size";
                    comboBox2.DataSource = null;
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("XS");
                    comboBox2.Items.Add("S");
                    comboBox2.Items.Add("M");
                    comboBox2.Items.Add("L");
                    comboBox2.Items.Add("XL");
                    comboBox2.Items.Add("XXL");


                }
                else if (comboBox1.Text == "Gender")
                {
                    phonesearch.Visible = false;
                    label5.Visible = false;
                    comboBox2.Visible = true;
                    label6.Visible = true;
                    label6.Text = "Gender";
                    comboBox2.DataSource = null;
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("M");
                    comboBox2.Items.Add("F");
                }
                else if(comboBox1.Text=="Type")
                {
                    phonesearch.Visible = false;
                    label5.Visible = false;
                    comboBox2.Visible = true;
                    label6.Visible = true;
                    label6.Text = "Type";
                    comboBox2.DataSource = null;
                    comboBox2.Items.Clear();
                    comboBox2.DataSource = controllerObj.SelectByClothesType();
                    comboBox2.DisplayMember = "Type";
                }


            }
            else if (formtype == "books")
            {
                
                if(comboBox1.Text=="Educational Year")
                {
                    phonesearch.Visible = false;
                    label5.Visible = false;
                    comboBox2.Visible = true;
                    label6.Visible = true;
                    label6.Text = "Year-Term";
                    comboBox2.DataSource = null;
                    comboBox2.Items.Clear();
                    comboBox2.DataSource = controllerObj.SelectByEduYear();
                    comboBox2.DisplayMember = "Educational_Year";
                    
                }
                else if (comboBox1.Text == "Subject")
                {
                    phonesearch.Visible = false;
                    label5.Visible = false;
                    comboBox2.Visible = true;
                    label6.Visible = true;
                    label6.Text = "Subject";
                    comboBox2.DataSource = null;
                    comboBox2.Items.Clear();
                    comboBox2.DataSource = controllerObj.SelectBySubject();
                    comboBox2.DisplayMember = "Subject";

                }


            }
            else if(formtype=="money")
            {
                if (comboBox1.Text=="Destination")
                {
                    phonesearch.Visible = false;
                    label5.Visible = false;
                    comboBox2.Visible = true;
                    label6.Visible = true;
                    label6.Text = "Destination";
                    comboBox2.DataSource = null;
                    comboBox2.Items.Clear();
                    comboBox2.DataSource = controllerObj.SelectByDestination();
                    comboBox2.DisplayMember = "Destination";

                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (formtype == "blood")
            {
                Blood_Dep b = new Blood_Dep(EmployeeID);
                b.Show();
                this.Hide();

            }
            else if (formtype == "food")
            {
                Food_Dep f = new Food_Dep(EmployeeID);
                f.Show();
                this.Hide();
            }
            else if (formtype == "clothes")
            {
                Cloths_Dep c = new Cloths_Dep(EmployeeID);
                c.Show();
                this.Hide();

            }
            else if (formtype == "books")
            {
                Books_Dep b = new Books_Dep(EmployeeID);
                b.Show();
                this.Hide();
            }
            else if(formtype == "money")
            {
                Money_Donations_Dep m = new Money_Donations_Dep(EmployeeID);
                m.Show();
                this.Hide();
            }
        }

        private void ViewDonations_Load(object sender, EventArgs e)
        {

        }

        private void viewbutton_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Phone Number"||comboBox1.Text=="Handling Employee")
            {
                
                if (phonesearch.Text=="")
                {
                    MessageBox.Show("Please enter all fields");
                    return;
                }
                if (phonesearch.TextLength != 11)
                {
                    MessageBox.Show("Please enter a valid phone number");
                    return;
                }
            }
          
            if (comboBox1.Text=="")
            {
                MessageBox.Show("Please enter all fields");
                return;
            }
            if(comboBox2.Visible==true && comboBox2.Text=="")
            {
                MessageBox.Show("Please enter all fields");
                return;
            }
            if (comboBox1.Text == "Phone Number")
            {
                DataTable dt = controllerObj.SelectDonationByPhoneNumber(phonesearch.Text, "Volunteer", formtype);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                if (dt == null)
                {
                    MessageBox.Show("No Donations for this number yet");
                    return;
                }

            }
            else if (comboBox1.Text == "Handling Employee")
            {
                DataTable dt = controllerObj.SelectDonationByPhoneNumber(phonesearch.Text, "employee", formtype);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                if (dt == null)
                {
                    MessageBox.Show("No Donations handled by this employee yet");
                    return;
                }

            }
         
            if (formtype == "blood")
            {
               
                if(comboBox1.Text=="Blood Type")
                {
                    DataTable dt = controllerObj.SelectByBloodType(comboBox2.Text);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    if (dt == null)
                    {
                        MessageBox.Show("No Donations of this Type yet");
                        return;
                    }

                }
                else if(comboBox1.Text=="Donation Date")
                {
                    DataTable dt = controllerObj.SelectBloodByDate(comboBox2.Text,"Donation");
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    if (dt == null)
                    {
                        MessageBox.Show("No Donations on this date");
                        return;
                    }

                }
                else if(comboBox1.Text=="Expiry Date")
                {
                    DataTable dt = controllerObj.SelectBloodByDate(comboBox2.Text,"Expiry");
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    if (dt == null)
                    {
                        MessageBox.Show("No Expired Items on this date");
                        return;
                    }

                }
                else if (comboBox1.Text == "All")
                {

                    DataTable dt = controllerObj.SelectAllBloodDonations();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    if (dt == null)
                    {
                        MessageBox.Show("No Donations yet");
                        return;
                    }
                }


            }
            else if (formtype == "food")
            {
                if (comboBox1.Text == "Food Type")
                {
                    DataTable dt = controllerObj.SelectFoodDonationByType(comboBox2.Text);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    if (dt == null)
                    {
                        MessageBox.Show("No Donations of this Type yet");
                        return;
                    }
                }
                else if (comboBox1.Text == "Expiry Date")
                {

                    DataTable dt = controllerObj.SelectFoodDonationByExpDate(comboBox2.Text);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    if (dt == null)
                    {
                        MessageBox.Show("No Expiring Products on this day");
                        return;
                    }

                }
                else if (comboBox1.Text == "All")
                {

                    DataTable dt = controllerObj.SelectAllFoodDonations();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    if (dt == null)
                    {
                        MessageBox.Show("No Donations yet");
                        return;
                    }
                }
            }
            else if (formtype == "clothes")
            {
             if(comboBox1.Text=="Type")
                {
                    DataTable dt = controllerObj.SelectClothesByType(comboBox2.Text);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    if (dt == null)
                    {
                        MessageBox.Show("No Donations of this type yet");
                        return;
                    }
                }
             else if(comboBox1.Text=="Gender")
                {
                    DataTable dt = controllerObj.SelectClothesByGender(comboBox2.Text);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    if (dt == null)
                    {
                        MessageBox.Show("No Donations for this gender yet");
                        return;
                    }
                }
             else if(comboBox1.Text=="Size")
                {
                    DataTable dt = controllerObj.SelectClothesBySize(comboBox2.Text);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    if (dt == null)
                    {
                        MessageBox.Show("No Donations for this size yet");
                        return;
                    }
                }
                else if (comboBox1.Text == "All")
                {

                    DataTable dt = controllerObj.SelectAllClothesDonations();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    if (dt == null)
                    {
                        MessageBox.Show("No Donations yet");
                        return;
                    }
                }

            }
            else if (formtype == "books")
            {
               

                if(comboBox1.Text=="Educational Year")
                {
                    DataTable dt = controllerObj.SelectBookDonationByYear(comboBox2.Text);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    if (dt == null)
                    {
                        MessageBox.Show("No Donations for this year yet");
                        return;
                    }
                }
                else if(comboBox1.Text=="Subject")
                {
                    DataTable dt = controllerObj.SelectBookDonationBySubject(comboBox2.Text);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    if (dt == null)
                    {
                        MessageBox.Show("No Donations for this subject yet");
                        return;
                    }
                }
                else if (comboBox1.Text == "All")
                {

                    DataTable dt = controllerObj.SelectAllBookDonations();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    if (dt == null)
                    {
                        MessageBox.Show("No Donations yet");
                        return;
                    }
                }
            }
            else if(formtype =="money")
            {
                if(comboBox1.Text=="Destination")
                {
                    DataTable dt = controllerObj.SelectDonationsByDestination(comboBox2.Text);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    if (dt == null)
                    {
                        MessageBox.Show("No Donations for this establishment yet");
                        return;
                    }
                }
                else if(comboBox1.Text=="All")
                {
                    DataTable dt = controllerObj.SelectAllMoneyDonations();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    if (dt == null)
                    {
                        MessageBox.Show("No Donations yet");
                        return;
                    }
                }
            }
        }

        private void donationType_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void phonesearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
