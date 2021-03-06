﻿using System;
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

    public partial class ViewPackages : Form
    {
        public int returnWhere
        {
            get;
            set;
        }
        public ViewPackages()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void ViewPackages_Load(object sender, EventArgs e)
        {

            displayDataGridView();
        }
        public void displayDataGridView()

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
