namespace WindowsFormsApplication2
{
    partial class TrackPackage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackPackage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearbtn = new System.Windows.Forms.Button();
            this.trackbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.trackno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackStatus = new System.Windows.Forms.GroupBox();
            this.trackingno = new System.Windows.Forms.Label();
            this.PkgSenderAdd = new System.Windows.Forms.Label();
            this.PkgReceiver = new System.Windows.Forms.Label();
            this.PkgSender = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PkgDate = new System.Windows.Forms.Label();
            this.PkgStatus = new System.Windows.Forms.Label();
            this.PkgDestination = new System.Windows.Forms.Label();
            this.PkgName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.trackStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearbtn);
            this.groupBox1.Controls.Add(this.trackbtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.trackno);
            this.groupBox1.Location = new System.Drawing.Point(11, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package Tracking";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(429, 114);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(75, 23);
            this.clearbtn.TabIndex = 3;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // trackbtn
            // 
            this.trackbtn.Location = new System.Drawing.Point(189, 114);
            this.trackbtn.Name = "trackbtn";
            this.trackbtn.Size = new System.Drawing.Size(75, 23);
            this.trackbtn.TabIndex = 2;
            this.trackbtn.Text = "Track";
            this.trackbtn.UseVisualStyleBackColor = true;
            this.trackbtn.Click += new System.EventHandler(this.trackbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Tracking Number";
            // 
            // trackno
            // 
            this.trackno.AccessibleDescription = "trackno";
            this.trackno.AccessibleName = "trackno";
            this.trackno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackno.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.trackno.Location = new System.Drawing.Point(189, 60);
            this.trackno.Multiline = true;
            this.trackno.Name = "trackno";
            this.trackno.Size = new System.Drawing.Size(315, 30);
            this.trackno.TabIndex = 0;
            this.trackno.Text = "TX000000";
            this.trackno.TextChanged += new System.EventHandler(this.trackno_TextChanged);
            this.trackno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trackno_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Track a Package";
            // 
            // trackStatus
            // 
            this.trackStatus.Controls.Add(this.trackingno);
            this.trackStatus.Controls.Add(this.PkgSenderAdd);
            this.trackStatus.Controls.Add(this.PkgReceiver);
            this.trackStatus.Controls.Add(this.PkgSender);
            this.trackStatus.Controls.Add(this.label10);
            this.trackStatus.Controls.Add(this.label9);
            this.trackStatus.Controls.Add(this.label8);
            this.trackStatus.Controls.Add(this.label7);
            this.trackStatus.Controls.Add(this.PkgDate);
            this.trackStatus.Controls.Add(this.PkgStatus);
            this.trackStatus.Controls.Add(this.PkgDestination);
            this.trackStatus.Controls.Add(this.PkgName);
            this.trackStatus.Controls.Add(this.label6);
            this.trackStatus.Controls.Add(this.label5);
            this.trackStatus.Controls.Add(this.label4);
            this.trackStatus.Controls.Add(this.label3);
            this.trackStatus.Location = new System.Drawing.Point(12, 298);
            this.trackStatus.Name = "trackStatus";
            this.trackStatus.Size = new System.Drawing.Size(509, 291);
            this.trackStatus.TabIndex = 2;
            this.trackStatus.TabStop = false;
            this.trackStatus.Text = "Track Status";
            // 
            // trackingno
            // 
            this.trackingno.AutoSize = true;
            this.trackingno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.trackingno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.trackingno.Location = new System.Drawing.Point(140, 248);
            this.trackingno.Name = "trackingno";
            this.trackingno.Size = new System.Drawing.Size(80, 16);
            this.trackingno.TabIndex = 15;
            this.trackingno.Text = "trackingno";
            // 
            // PkgSenderAdd
            // 
            this.PkgSenderAdd.AutoSize = true;
            this.PkgSenderAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.PkgSenderAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PkgSenderAdd.Location = new System.Drawing.Point(137, 216);
            this.PkgSenderAdd.Name = "PkgSenderAdd";
            this.PkgSenderAdd.Size = new System.Drawing.Size(113, 16);
            this.PkgSenderAdd.TabIndex = 14;
            this.PkgSenderAdd.Text = "PkgSenderAdd";
            // 
            // PkgReceiver
            // 
            this.PkgReceiver.AutoSize = true;
            this.PkgReceiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.PkgReceiver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PkgReceiver.Location = new System.Drawing.Point(137, 189);
            this.PkgReceiver.Name = "PkgReceiver";
            this.PkgReceiver.Size = new System.Drawing.Size(98, 16);
            this.PkgReceiver.TabIndex = 13;
            this.PkgReceiver.Text = "PkgReceiver";
            // 
            // PkgSender
            // 
            this.PkgSender.AutoSize = true;
            this.PkgSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.PkgSender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PkgSender.Location = new System.Drawing.Point(137, 160);
            this.PkgSender.Name = "PkgSender";
            this.PkgSender.Size = new System.Drawing.Size(85, 16);
            this.PkgSender.TabIndex = 12;
            this.PkgSender.Text = "PkgSender";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Tracking No.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Sender Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Receiver Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sender Name";
            // 
            // PkgDate
            // 
            this.PkgDate.AutoSize = true;
            this.PkgDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.PkgDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PkgDate.Location = new System.Drawing.Point(137, 130);
            this.PkgDate.Name = "PkgDate";
            this.PkgDate.Size = new System.Drawing.Size(68, 16);
            this.PkgDate.TabIndex = 7;
            this.PkgDate.Text = "PkgDate";
            // 
            // PkgStatus
            // 
            this.PkgStatus.AutoSize = true;
            this.PkgStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.PkgStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PkgStatus.Location = new System.Drawing.Point(135, 100);
            this.PkgStatus.Name = "PkgStatus";
            this.PkgStatus.Size = new System.Drawing.Size(78, 16);
            this.PkgStatus.TabIndex = 6;
            this.PkgStatus.Text = "PkgStatus";
            // 
            // PkgDestination
            // 
            this.PkgDestination.AutoSize = true;
            this.PkgDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.PkgDestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PkgDestination.Location = new System.Drawing.Point(134, 69);
            this.PkgDestination.Name = "PkgDestination";
            this.PkgDestination.Size = new System.Drawing.Size(113, 16);
            this.PkgDestination.TabIndex = 5;
            this.PkgDestination.Text = "PkgDestination";
            // 
            // PkgName
            // 
            this.PkgName.AutoSize = true;
            this.PkgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PkgName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PkgName.Location = new System.Drawing.Point(134, 41);
            this.PkgName.Name = "PkgName";
            this.PkgName.Size = new System.Drawing.Size(76, 16);
            this.PkgName.TabIndex = 4;
            this.PkgName.Text = "PkgName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Package Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::WindowsFormsApplication2.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(12, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(451, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TrackPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(544, 601);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trackStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "TrackPackage";
            this.Text = "TrackPackage";
            this.Load += new System.EventHandler(this.TrackPackage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.trackStatus.ResumeLayout(false);
            this.trackStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button trackbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox trackno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox trackStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PkgDate;
        private System.Windows.Forms.Label PkgStatus;
        private System.Windows.Forms.Label PkgDestination;
        private System.Windows.Forms.Label PkgName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label trackingno;
        private System.Windows.Forms.Label PkgSenderAdd;
        private System.Windows.Forms.Label PkgReceiver;
        private System.Windows.Forms.Label PkgSender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}