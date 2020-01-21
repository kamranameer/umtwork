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
    public partial class ViewEmployees : Form
    {
        public ViewEmployees()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain AdmForm = new FrmMain();
            AdmForm.Show();
        }


        public void displayDataGridView()

        {

            dbProcess MainDB = new dbProcess();

            using (SqlCommand cmd = new SqlCommand())
            {
                MainDB.openConnection();

                cmd.CommandText = "Select LoginId as 'User No.', UserName as 'User Name',Role as 'Current Role' from Users";
                cmd.Connection = MainDB.conn;
                cmd.Transaction = MainDB.transaction;
                try

                {

                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = cmd;

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dt;

                    dataGridView1.DataSource = bsource;

                }

                catch (Exception ec)

                {

                    MessageBox.Show(ec.Message);

                }

            }
        }

        private void ViewEmployees_Load(object sender, EventArgs e)
        {
            displayDataGridView();
        }
    }
}
