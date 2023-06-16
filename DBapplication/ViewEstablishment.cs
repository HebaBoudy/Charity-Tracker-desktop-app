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
    public partial class ViewEstablishment : Form
    {
        int handler;
        Controller controllerobj;
        public ViewEstablishment(int employee)
        {
            handler = employee;
            controllerobj = new Controller();
            
            InitializeComponent();
            EstablishmentName.Enabled = false;
            EstablishmentName.DataSource = controllerobj.SelectAllEstablishments();
            EstablishmentName.DisplayMember = "Name";

        }

        private void ViewBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ViewBy.Text=="Name")
            {
                EstablishmentName.Enabled = true;
            }
            if (ViewBy.Text == "All")
            {
                EstablishmentName.Enabled = false;
            }
        }

        private void View_Click(object sender, EventArgs e)
        {
            if (ViewBy.Text == "All")
            {
                dataGridView1.DataSource = controllerobj.SelectAllEstablishments();
                dataGridView1.Refresh();
            }
            if (ViewBy.Text == "Name")
            {
                EstablishmentName.Enabled = true;
                dataGridView1.DataSource = controllerobj.SelectEstablishmentByName(EstablishmentName.Text);
                dataGridView1.Refresh();
            }
        }

        private void EstablishmentName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Establishments E = new Establishments(handler);
            this.Hide();
            E.Show();
        }
    }
}
