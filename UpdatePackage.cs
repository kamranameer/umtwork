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
    public partial class UpdatePackage : Form
    {
        public UpdatePackage()
        {
            InitializeComponent();
            updPkgTitle.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeForm EmpForm = new EmployeeForm();
            EmpForm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updPkgTitle.Show();
            int ind = e.RowIndex;
            DataGridViewRow selectedRows = dataGridView1.Rows[ind];
            updPkgTitle.Text = "Update Package : "+ selectedRows.Cells[0].Value.ToString();
            //delTrackNo.Text = selectedRows.Cells[4].Value.ToString();
            updPkgTitle.Show();

        }
        private void UpdatePackage_Load(object sender, EventArgs e)
        {
            dbProcess MainDB = new dbProcess();

            using (SqlCommand cmd = new SqlCommand())
            {
                MainDB.openConnection();

                cmd.CommandText = "Select Id as 'ID',PkgName as 'Name',PkgDestination as 'Destination',PkgStatus as 'Status',trackinno as  'Tracking',PkgDate as 'Date',PkgReceiver as 'Receiver Name',PkgSender as 'Sender Name',PkgSenderAdd as 'Sender Address' from Packages";
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
    }
}
