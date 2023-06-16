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
    public partial class MyBusses : Form
    {
        int EmployeeID;
        Controller controllerObj;
        public MyBusses(int empid)
        {
            controllerObj = new Controller();
            EmployeeID = empid;
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminProvidedFunctionalities a = new AdminProvidedFunctionalities(EmployeeID);
            a.Show();
            this.Hide();
        }

        private void addBus_Click(object sender, EventArgs e)
        {
            int id;
            DataTable dt = controllerObj.GenerateBusID();
            if (dt.Rows[0][0].ToString() != "")
            {
                id = Convert.ToInt32(dt.Rows[0][0].ToString());
                id += 1;
            }
            else id = 1;

            int r = controllerObj.InsertBus(id, Convert.ToInt32(numericUpDown1.Value));
            if(r==0)
            {
                MessageBox.Show("Insertion Failed");
                return;
            }
            else
            {
                MessageBox.Show("Bus Inserted Successfully");
                dataGridView1.Refresh();
                return;
            }
            
        }

        private void viewBus_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllBusses();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
