using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addEmp_Click(object sender, EventArgs e)
        {
            dbProcess MainDB = new dbProcess();
            using (SqlCommand cmd = new SqlCommand())
            {
                MainDB.openConnection();
                cmd.CommandText = "INSERT INTO Users VALUES (@v1, @v2,'employee')";
                cmd.Connection = MainDB.conn;
                cmd.Transaction = MainDB.transaction;
                cmd.CommandType = CommandType.Text;
               
                cmd.Parameters.AddWithValue("v1", userName.Text.Trim());
                cmd.Parameters.AddWithValue("v2", password.Text.Trim());
          
                try
                {
                    int i = cmd.ExecuteNonQuery();

                    if (i == 1)
                    {
                        MessageBox.Show(userName.Text.Trim()+" has been added as an employee!",
                                     "Success",
                                     MessageBoxButtons.OK,MessageBoxIcon.Information);
                     
                    }
                    else
                    {
                        MessageBox.Show("There was an error adding employee.",
                                     "Error",
                                     MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Something wrong happened in the InsertRecord Module :", ex);
                }
                finally
                {
                    MainDB.closeConnection();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain AdmForm = new FrmMain();
            AdmForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain AdmForm = new FrmMain();
            AdmForm.Show();
        }
    }
}
