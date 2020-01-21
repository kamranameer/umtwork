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
    public partial class TrackPackage : Form
    {
        public int returnWhere
        {
            get;
            set;
        }
        public TrackPackage()
        {
            InitializeComponent();
            trackStatus.Hide();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            trackno.Text = "";
            trackStatus.Hide();

        }
        private void trackno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                trackbtn.PerformClick();
            }
        }
        private void trackbtn_Click(object sender, EventArgs e)
        {
            if (trackno.Text == "")
            {
                MessageBox.Show("Track No. Cannot be empty!");
                return;
            }
            else
            {

                /* PkgName.Text = "Package Name from db";
                PkgDestination.Text = "Rawalpindi";
                PkgDate.Text = "05/05/2019";
                PkgStatus.Text = "Enroute to destination";*/

                //Now we get tracking details from database.
                bool Tracked = false;
                dbProcess MainDB = new dbProcess(); //create a object for dbProcess class
                dbTrack TrackPack = new dbTrack(); //create a object for dbUser class
                TrackPack.TrackingNo = trackno.Text.Trim();
                Tracked = TrackPack.GetTrackingInfo();
                if (Tracked)
                {

                    PkgName.Text = TrackPack.PackageName;
                    PkgDestination.Text = TrackPack.PackageDestination;
                    PkgDate.Text = TrackPack.PackageDate;
                    PkgStatus.Text = TrackPack.PackageStatus;
                    PkgReceiver.Text = TrackPack.PackageReceiver;
                    PkgSender.Text = TrackPack.PackageSender;
                    PkgSenderAdd.Text = TrackPack.PackageSenderAddress;
                    trackingno.Text = trackno.Text;
                    trackStatus.Show();
                }
                else
                {
                    MessageBox.Show("Error tracking the package");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            FrmMain AdminForm = new FrmMain();
            AdminForm.Show();
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

        private void TrackPackage_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void trackno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
