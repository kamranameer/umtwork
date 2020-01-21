namespace WindowsFormsApplication2
{
    partial class NewPackage
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PkgName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PkgStatus = new System.Windows.Forms.TextBox();
            this.statusofpak = new System.Windows.Forms.Label();
            this.genTracker = new System.Windows.Forms.Button();
            this.TrackingNo = new System.Windows.Forms.TextBox();
            this.receiverAddress = new System.Windows.Forms.TextBox();
            this.receiverName = new System.Windows.Forms.TextBox();
            this.senderAddress = new System.Windows.Forms.TextBox();
            this.senderName = new System.Windows.Forms.TextBox();
            this.goBack = new System.Windows.Forms.Button();
            this.addPackage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a New Package";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PkgName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PkgStatus);
            this.groupBox1.Controls.Add(this.statusofpak);
            this.groupBox1.Controls.Add(this.genTracker);
            this.groupBox1.Controls.Add(this.TrackingNo);
            this.groupBox1.Controls.Add(this.receiverAddress);
            this.groupBox1.Controls.Add(this.receiverName);
            this.groupBox1.Controls.Add(this.senderAddress);
            this.groupBox1.Controls.Add(this.senderName);
            this.groupBox1.Controls.Add(this.goBack);
            this.groupBox1.Controls.Add(this.addPackage);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(30, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 442);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Details";
            // 
            // PkgName
            // 
            this.PkgName.Location = new System.Drawing.Point(201, 351);
            this.PkgName.Name = "PkgName";
            this.PkgName.Size = new System.Drawing.Size(231, 20);
            this.PkgName.TabIndex = 18;
            this.PkgName.Text = "Any Package Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Unique Name";
            // 
            // PkgStatus
            // 
            this.PkgStatus.Location = new System.Drawing.Point(201, 302);
            this.PkgStatus.Name = "PkgStatus";
            this.PkgStatus.Size = new System.Drawing.Size(231, 20);
            this.PkgStatus.TabIndex = 16;
            this.PkgStatus.Text = "Processed";
            // 
            // statusofpak
            // 
            this.statusofpak.AutoSize = true;
            this.statusofpak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusofpak.Location = new System.Drawing.Point(36, 300);
            this.statusofpak.Name = "statusofpak";
            this.statusofpak.Size = new System.Drawing.Size(136, 20);
            this.statusofpak.TabIndex = 15;
            this.statusofpak.Text = "Package Status";
            // 
            // genTracker
            // 
            this.genTracker.Location = new System.Drawing.Point(245, 251);
            this.genTracker.Name = "genTracker";
            this.genTracker.Size = new System.Drawing.Size(149, 23);
            this.genTracker.TabIndex = 14;
            this.genTracker.Text = "Generate New Tracking No.";
            this.genTracker.UseVisualStyleBackColor = true;
            this.genTracker.Click += new System.EventHandler(this.button3_Click);
            // 
            // TrackingNo
            // 
            this.TrackingNo.Location = new System.Drawing.Point(201, 225);
            this.TrackingNo.Name = "TrackingNo";
            this.TrackingNo.Size = new System.Drawing.Size(231, 20);
            this.TrackingNo.TabIndex = 13;
            // 
            // receiverAddress
            // 
            this.receiverAddress.Location = new System.Drawing.Point(201, 171);
            this.receiverAddress.Name = "receiverAddress";
            this.receiverAddress.Size = new System.Drawing.Size(231, 20);
            this.receiverAddress.TabIndex = 12;
            // 
            // receiverName
            // 
            this.receiverName.Location = new System.Drawing.Point(201, 130);
            this.receiverName.Name = "receiverName";
            this.receiverName.Size = new System.Drawing.Size(231, 20);
            this.receiverName.TabIndex = 11;
            // 
            // senderAddress
            // 
            this.senderAddress.Location = new System.Drawing.Point(201, 89);
            this.senderAddress.Name = "senderAddress";
            this.senderAddress.Size = new System.Drawing.Size(231, 20);
            this.senderAddress.TabIndex = 10;
            // 
            // senderName
            // 
            this.senderName.Location = new System.Drawing.Point(201, 45);
            this.senderName.Name = "senderName";
            this.senderName.Size = new System.Drawing.Size(231, 20);
            this.senderName.TabIndex = 9;
            // 
            // goBack
            // 
            this.goBack.Location = new System.Drawing.Point(357, 382);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(75, 23);
            this.goBack.TabIndex = 8;
            this.goBack.Text = "Cancel";
            this.goBack.UseVisualStyleBackColor = true;
            // 
            // addPackage
            // 
            this.addPackage.Location = new System.Drawing.Point(201, 382);
            this.addPackage.Name = "addPackage";
            this.addPackage.Size = new System.Drawing.Size(75, 23);
            this.addPackage.TabIndex = 7;
            this.addPackage.Text = "Add Package";
            this.addPackage.UseVisualStyleBackColor = true;
            this.addPackage.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sender Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Receiver Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tracking Number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Receiver Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sender Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::WindowsFormsApplication2.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(30, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 65);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.diagram_v2_18;
            this.pictureBox1.Location = new System.Drawing.Point(433, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NewPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(551, 568);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPackage";
            this.Text = "Add New Package";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button genTracker;
        private System.Windows.Forms.TextBox TrackingNo;
        private System.Windows.Forms.TextBox receiverAddress;
        private System.Windows.Forms.TextBox receiverName;
        private System.Windows.Forms.TextBox senderAddress;
        private System.Windows.Forms.TextBox senderName;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Button addPackage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox PkgStatus;
        private System.Windows.Forms.Label statusofpak;
        private System.Windows.Forms.TextBox PkgName;
        private System.Windows.Forms.Label label4;
    }
}