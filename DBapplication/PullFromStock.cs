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
    
    public partial class PullFromStock : Form
    {
        string formtype;
        Controller controllerObj;
        int EmployeeID;
        public PullFromStock(int empid, string ftype)
        {
            EmployeeID = empid;
            formtype = ftype;
            InitializeComponent();
            controllerObj = new Controller();
            if (formtype == "blood")
            {
                replacelabel2.Visible = false;
                replacelabel3.Visible = false;
                selection2.Visible = false;
                selection3.Visible = false;
                donationType.Text = "Blood";
                replacelabel.Text = "Type";
                
                mainSelection.DisplayMember = "Type";
                mainSelection.DataSource = controllerObj.SelectAllBloodStock();
                dataGridView1.DataSource= controllerObj.SelectAllBloodStock();
                dataGridView1.Refresh();
            }
            else if (formtype == "food")
            {
                replacelabel2.Visible = false;
                replacelabel3.Visible = false;
                selection2.Visible = false;
                selection3.Visible = false;
                donationType.Text = "Food";
                replacelabel.Text = "Type";
                mainSelection.DisplayMember = "Name";
                mainSelection.DataSource = controllerObj.SelectAllFoodStock();
                dataGridView1.DataSource = controllerObj.SelectAllFoodStock();
                dataGridView1.Refresh();
            }
            else if (formtype == "clothes")
            {
                replacelabel2.Visible = true;
                replacelabel3.Visible = true;
                selection2.Visible = true;
                selection3.Visible = true;
                donationType.Text = "Clothes";
                replacelabel.Text = "Type";
                replacelabel2.Text = "Size";
                replacelabel3.Text = "Gender";
                mainSelection.DisplayMember = "Type";
                selection2.DisplayMember = "Size";
                selection3.DisplayMember = "Gender";
                mainSelection.DataSource = controllerObj.SelectAllClothesStock();
                selection2.DataSource = controllerObj.SelectAllClothesStockSize();
                selection3.DataSource = controllerObj.SelectAllClothesStockGender();
                dataGridView1.DataSource = controllerObj.SelectAllClothesStock();
                dataGridView1.Refresh();

            }
            else if (formtype == "books")
            {
                replacelabel2.Visible = true;
                replacelabel3.Visible = true;
                selection2.Visible = true;
                selection3.Visible = true;
                donationType.Text = "Books";
                replacelabel.Text = "Name";
                replacelabel2.Text = "Educational Year";
                replacelabel3.Text = "Subject";
                mainSelection.DisplayMember = "Name";
                selection2.DisplayMember = "Educational_year";
                selection3.DisplayMember = "Subject";
                mainSelection.DataSource = controllerObj.SelectAllBooksStock();
                selection2.DataSource = controllerObj.SelectAllBooksStockEduYear();
                selection3.DataSource = controllerObj.SelectAllBooksStockSubject();
                dataGridView1.DataSource = controllerObj.SelectAllBooksStock();
                dataGridView1.Refresh();
            }
        }

        private void PullFromStock_Load(object sender, EventArgs e)
        {

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
        }

        private void executebutton_Click(object sender, EventArgs e)
        {
            if (formtype == "blood")
            {
                if (mainSelection.Text == "")
                {
                    MessageBox.Show("Please Choose A Blood Type");
                    return;
                }
                else
                {
                    int quantity;
                    DataTable dt = controllerObj.getQuantity(mainSelection.Text);
                    if (Convert.ToInt32(dt.Rows[0][0]) == 0)
                    {
                        MessageBox.Show("Out of Stock");
                        return;
                    }
                    else
                    {
                        quantity = (Convert.ToInt32(dt.Rows[0][0]));
                        if (quantity < Convert.ToInt32(numericUpDown1.Value))
                        {
                            MessageBox.Show("Insufficient Stock");
                            return;
                        }
                        else
                        {
                            controllerObj.RemoveBlood(mainSelection.Text, Convert.ToInt32(numericUpDown1.Value));
                            MessageBox.Show("Pulled Successfully");
                            dataGridView1.DataSource = controllerObj.SelectAllBloodStock();
                            dataGridView1.Refresh();
                            return;
                        }

                    }
                }
            }
            else if (formtype == "food")
            {
                if (mainSelection.Text == "")
                {
                    MessageBox.Show("Please Choose A Food Type");
                    return;
                }
                else
                {
                    int quantity;
                    DataTable dt = controllerObj.getQuantityFood(mainSelection.Text);
                    if (Convert.ToInt32(dt.Rows[0][0]) == 0)
                    {
                        MessageBox.Show("Out of Stock");
                        return;
                    }
                    else
                    {
                        quantity = (Convert.ToInt32(dt.Rows[0][0]));
                        if (quantity < Convert.ToInt32(numericUpDown1.Value))
                        {
                            MessageBox.Show("Insufficient Stock");
                            return;
                        }
                        else
                        {
                            controllerObj.RemoveFood(mainSelection.Text, Convert.ToInt32(numericUpDown1.Value));
                            MessageBox.Show("Pulled Successfully");
                            dataGridView1.DataSource = controllerObj.SelectAllFoodStock();
                            dataGridView1.Refresh();
                            return;
                        }

                    }
                }
            }
            else if (formtype == "clothes")
            {
                if (mainSelection.Text == "" || selection2.Text == "" || selection3.Text == "")
                {
                    MessageBox.Show("Please Fill all Data");
                    return;
                }
                else
                {
                    int quantity;
                    DataTable dt = controllerObj.getQuantityClothes(mainSelection.Text, selection2.Text, selection3.Text);
                    if (Convert.ToInt32(dt.Rows[0][0]) == 0)
                    {
                        MessageBox.Show("Out of Stock");
                        return;
                    }
                    else
                    {
                        quantity = (Convert.ToInt32(dt.Rows[0][0]));
                        if (quantity < Convert.ToInt32(numericUpDown1.Value))
                        {
                            MessageBox.Show("Insufficient Stock");
                            return;
                        }
                        else
                        {
                            controllerObj.RemoveClothes(mainSelection.Text, selection2.Text, selection3.Text, Convert.ToInt32(numericUpDown1.Value));
                            MessageBox.Show("Pulled Successfully");
                            dataGridView1.DataSource = controllerObj.SelectAllClothesStock();
                            dataGridView1.Refresh();
                            return;
                        }

                    }
                }
            }
            else if (formtype == "books")
            {
                if (mainSelection.Text == "" || selection2.Text == "" || selection3.Text == "")
                {
                    MessageBox.Show("Please Fill all Data");
                    return;
                }
                else
                {
                    int quantity;
                    DataTable dt = controllerObj.getQuantityBooks(mainSelection.Text, selection2.Text, selection3.Text);
                    if (Convert.ToInt32(dt.Rows[0][0]) == 0)
                    {
                        MessageBox.Show("Out of Stock");
                        return;
                    }
                    else
                    {
                        quantity = (Convert.ToInt32(dt.Rows[0][0]));
                        if (quantity < Convert.ToInt32(numericUpDown1.Value))
                        {
                            MessageBox.Show("Insufficient Stock");
                            return;
                        }
                        else
                        {
                            controllerObj.RemoveBook(mainSelection.Text, Convert.ToInt32(numericUpDown1.Value), selection2.Text, selection3.Text);
                            MessageBox.Show("Pulled Successfully");
                            dataGridView1.DataSource = controllerObj.SelectAllBooksStock();
                            dataGridView1.Refresh();
                            return;
                        }

                    }
                }

            }
        }
    }
}
