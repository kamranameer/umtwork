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
    
    public partial class NewPackage : Form
    {
        //for generating random tracking numbers
        private static Random random = new Random();
        public NewPackage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public static string GenerateTrackingNo(int length)
        {
         
        const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            TrackingNo.Text = "TX" + GenerateTrackingNo(6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbProcess MainDB = new dbProcess(); 
            InsertNewRecord InsertNewRec = new InsertNewRecord();
            /*

PkgName
PkgDestination
PkgStatus
trackingno
PkgDate
PkgReceiver
PkgSender
PkgReceiverAdd
PkgSenderAdd

*/
            DateTime todayDate = DateTime.Today;
            string dateT = todayDate.ToString("dd-MM-yyyy");
            if (PkgName.Text == "" ||
                        receiverAddress.Text == "" ||
                        PkgStatus.Text == "" ||
                        TrackingNo.Text == "" ||
                        receiverName.Text == "" ||
                        senderName.Text == "" ||
                        receiverAddress.Text == "" ||
                        senderAddress.Text == "")
            {
                MessageBox.Show("Some fields are empty, you must fill all of them",
                                   "Error, you must enter all fields.",
                                   MessageBoxButtons.OK);
            }
            else
            {


                if (@InsertNewRec.saveToDb(PkgName.Text.Trim(),
                    receiverAddress.Text.Trim(),
                    PkgStatus.Text.Trim(),
                    TrackingNo.Text.Trim(),
                    dateT,
                    receiverName.Text.Trim(),
                    senderName.Text.Trim(),
                    receiverAddress.Text.Trim(),
                    senderAddress.Text.Trim()


                    ))
                {
                    MessageBox.Show("Data has been added!",
                                       "Success",
                                       MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Data was not added!",
                                      "Error",
                                      MessageBoxButtons.OK);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (senderName.Text == "" ||
                        receiverAddress.Text == "" ||
                        senderName.Text == "" ||
                        TrackingNo.Text == "" ||
                        senderName.Text == "" ||
                        receiverName.Text == "" ||
                        senderName.Text == "" ||
                        receiverAddress.Text == "" ||
                        senderAddress.Text == "")
            {
                this.Hide();
                EmployeeForm EmpForm = new EmployeeForm();
                EmpForm.Show();
            }
            else
            {
                var confirmResult = MessageBox.Show("Go back without saving data?",
                                    "Are you Sure?",
                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    this.Hide();
                    EmployeeForm EmpForm = new EmployeeForm();
                    EmpForm.Show();
                }
                else
                {
                    return;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
