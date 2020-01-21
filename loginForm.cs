using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//For connecting to sql database.
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
namespace WindowsFormsApplication2
{
    public partial class loginForm : Form
    {
   
       public static string uname;
        public static string passw;
        public new System.Windows.Forms.IButtonControl AcceptButton { get; set; }

        public loginForm()
        {
            InitializeComponent();
        }



        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void TxtPassword_KeyPress( object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UserLogin();
            }
        }
        private void doLogin_Click(object sender, EventArgs e)
        {
            uname = TxtUserName.Text.Trim();
            passw = TxtPassword.Text.Trim();
            UserLogin();
        }

        private void QuitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        dbProcess MainDB = new dbProcess(); //create a object for dbProcess class
        dbUser LogUser = new dbUser(); //create a object for dbUser class
        bool LoginOk = false; // login Flag
        
        private void UserLogin()
        {
            // TxtUserName.Text = "Username";
            //  TxtPassword.Text = "123456";
        

            if (TxtUserName.Text == "") // check Username is Empty or Not
            {
                return;
            }

            if (TxtPassword.Text == "") // check Password is Empty or Not
            {
                return;
            }

            LogUser.UserName = TxtUserName.Text.Trim();
            LogUser.Password = TxtPassword.Text.Trim();
            LoginOk = LogUser.ValidRegLogUser();
           /* MessageBox.Show("user: "+uname+" and password: "+passw,
                   "This is just debugging msg", MessageBoxButtons.OK, MessageBoxIcon.Error);*/

            if (LoginOk)
            {
                if (LogUser.Role == "admin")
                {
                    FrmMain MainForm = new FrmMain();
                    this.Hide();
                    MainForm.Show();
                }
                if (LogUser.Role == "employee")
                {
                    EmployeeForm MainForm = new EmployeeForm();
                    this.Hide();
                    MainForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Please check username and password",
                  "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }



}
;