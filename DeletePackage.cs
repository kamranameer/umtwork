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
    public partial class DeletePackage : Form
    {
        public int returnWhere
        {
            get;
            set;
        }
        public DeletePackage()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DeletePackage_Load(object sender, EventArgs e)
        {
            displayDataGridView();
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int ind = e.RowIndex;
            DataGridViewRow selectedRows = dataGridView1.Rows[ind];
            delTrackNo.Text = selectedRows.Cells[4].Value.ToString();
           
        }
        public void displayDataGridView()

        {

            dbProcess MainDB = new dbProcess();

            using (SqlCommand cmd = new SqlCommand())
            {
                MainDB.openConnection();

                cmd.CommandText = "Select * from Packages";
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

        private void button1_Click(object sender, EventArgs e)
        {
            //delete this 
            if(delTrackNo.Text.Trim() != "")
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete?",
                                    "Confirm Delete?",
                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                   
                dbProcess MainDB = new dbProcess();
                using (SqlCommand cmd = new SqlCommand())
                {
                    MainDB.openConnection();
               //     cmd.CommandText = "DELETE from Packages where trackinno=TX518553";
                 //   cmd.Parameters.AddWithValue("@trackNo", delTrackNo.Text.Trim());
                    cmd.CommandType = CommandType.Text;
                    /*to refresh data grid view */
                    cmd.CommandText = "Select * from Packages";
                    cmd.Connection = MainDB.conn;
                    cmd.Transaction = MainDB.transaction;
                    try

                    {
                        SqlDataAdapter da = new SqlDataAdapter();
                        MainDB.openConnection();
                        da.DeleteCommand = new SqlCommand("DELETE FROM Packages WHERE trackinno='" + delTrackNo.Text.Trim() + "'", MainDB.conn);
                        SqlTransaction tran = MainDB.transaction;
                        da.DeleteCommand.Transaction = tran;
                        da.DeleteCommand.ExecuteNonQuery();
                        tran.Commit();
                        MessageBox.Show("Successfully Deleted");
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
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You must enter a Tracking No. to delete its records.", "Error", MessageBoxButtons.OK);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (returnWhere == 2)
            {
                EmployeeForm EmpForm = new EmployeeForm();
                EmpForm.Show();
            }
            else
            {
                FrmMain AdminForm = new FrmMain();
                AdminForm.Show();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
