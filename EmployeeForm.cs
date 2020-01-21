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
    public partial class EmployeeForm : Form
    {
        
        public EmployeeForm()
        {
            InitializeComponent();
            //welcomeTxt.Text = "Welcome, "+loginForm.uname;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
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

        private void welcomeTxt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrackPackage TrackForm = new TrackPackage();
            TrackForm.returnWhere = 2;
            TrackForm.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewPackage NewPackForm = new NewPackage();
            NewPackForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewPackages ViewPackForm = new ViewPackages();
            ViewPackForm.returnWhere = 2;
            ViewPackForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeletePackage DeletePackForm = new DeletePackage();
            DeletePackForm.returnWhere = 2;
            DeletePackForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdatePackage UpdatePackForm = new UpdatePackage();
            UpdatePackForm.Show();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
