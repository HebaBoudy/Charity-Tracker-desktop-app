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
    public partial class Establishments : Form
    {
        int Handler_Id;
        public Establishments(int Employee_id)
        {
            Handler_Id = Employee_id;
            InitializeComponent();
        }

        private void AddEstablishments_Click(object sender, EventArgs e)
        {
            AddNewEstablishment a = new AddNewEstablishment(Handler_Id);
            this.Hide();
            a.Show();
        }

        private void ViewEstablishments_Click(object sender, EventArgs e)
        {
            ViewEstablishment v = new ViewEstablishment(Handler_Id);
            this.Hide();
            v.Show();
        }

        private void DeleteEstablishment_Click(object sender, EventArgs e)
        {
            DeleteEstablishment d = new DeleteEstablishment(Handler_Id);
            this.Hide();
            d.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminProvidedFunctionalities a = new AdminProvidedFunctionalities(Handler_Id);
            this.Hide();
            a.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
