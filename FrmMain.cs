using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to logout?",
                                     "Confirm Logout?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Hide();
                loginForm login = new loginForm();
                login.Show();
            }
            else
            {
                return;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            TrackPackage TrackForm = new TrackPackage();
            TrackForm.returnWhere = 1;
            TrackForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewPackages ViewPackForm = new ViewPackages();
            ViewPackForm.returnWhere = 1;
            ViewPackForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeletePackage DeletePackForm = new DeletePackage();
            DeletePackForm.returnWhere = 1;
            DeletePackForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewEmployees ViewEmpForm = new ViewEmployees();
            ViewEmpForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteEmployee DeleteEmpForm = new DeleteEmployee();
            DeleteEmpForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployee AddEmpForm = new AddEmployee();
            AddEmpForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IT IS IN WORKING");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
