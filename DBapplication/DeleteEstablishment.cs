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
    public partial class DeleteEstablishment : Form
    {
        int handler_id;
        Controller controllerobj;
        public DeleteEstablishment(int employee)
        {
            handler_id = employee;
            controllerobj = new Controller();
            InitializeComponent();
            
            EstablishmentName.DataSource = controllerobj.SelectAllEstablishments();
            EstablishmentName.DisplayMember = "Name";
            EstablishmentName.SelectedIndex = -1;
        }

        private void EstablishmentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controllerobj.SelectEstablishmentByName(EstablishmentName.Text);
            dataGridView1.Refresh();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (EstablishmentName.Text == "")
            {
                MessageBox.Show("Please Select an establishment to be deleted!!");
            }
            else
            {
                int a = controllerobj.DeleteEstablishment(EstablishmentName.Text);
                if (a == 0)
                {
                    MessageBox.Show(" failed to delete ");

                }
                else
                {
                    MessageBox.Show("Deleted Successfully");
                    EstablishmentName.DataSource = controllerobj.SelectAllEstablishments();
                    EstablishmentName.DisplayMember = "Name";
                    EstablishmentName.SelectedIndex = -1;
                    dataGridView1.DataSource = controllerobj.SelectEstablishmentByName(EstablishmentName.Text);
                    dataGridView1.Refresh();

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
