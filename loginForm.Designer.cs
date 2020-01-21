namespace WindowsFormsApplication2
{
    partial class loginForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.QuitProgram = new System.Windows.Forms.Button();
            this.doLogin = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "POST OFFICE MANAGEMENT SYSTEM";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.QuitProgram);
            this.groupBox1.Controls.Add(this.doLogin);
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.TxtUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(-8, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 218);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication2.Properties.Resources.login;
            this.pictureBox2.Location = new System.Drawing.Point(18, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // QuitProgram
            // 
            this.QuitProgram.BackColor = System.Drawing.Color.Red;
            this.QuitProgram.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.QuitProgram.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.QuitProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.QuitProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.QuitProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitProgram.ForeColor = System.Drawing.Color.White;
            this.QuitProgram.Location = new System.Drawing.Point(341, 135);
            this.QuitProgram.Name = "QuitProgram";
            this.QuitProgram.Size = new System.Drawing.Size(75, 23);
            this.QuitProgram.TabIndex = 5;
            this.QuitProgram.Text = "Exit";
            this.QuitProgram.UseVisualStyleBackColor = false;
            this.QuitProgram.Click += new System.EventHandler(this.QuitProgram_Click);
            // 
            // doLogin
            // 
            this.doLogin.BackColor = System.Drawing.Color.Chartreuse;
            this.doLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.doLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.doLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.doLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doLogin.Location = new System.Drawing.Point(192, 135);
            this.doLogin.Name = "doLogin";
            this.doLogin.Size = new System.Drawing.Size(73, 23);
            this.doLogin.TabIndex = 4;
            this.doLogin.Text = "Login";
            this.doLogin.UseVisualStyleBackColor = false;
            this.doLogin.Click += new System.EventHandler(this.doLogin_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.AcceptsReturn = true;
            this.TxtPassword.AcceptsTab = true;
            this.TxtPassword.AccessibleName = "TxtPassword";
            this.TxtPassword.Location = new System.Drawing.Point(192, 75);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(224, 20);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            this.TxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPassword_KeyPress);
            // 
            // TxtUserName
            // 
            this.TxtUserName.AccessibleDescription = "TxtUserName";
            this.TxtUserName.Location = new System.Drawing.Point(192, 32);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(224, 20);
            this.TxtUserName.TabIndex = 2;
            this.TxtUserName.TextChanged += new System.EventHandler(this.TxtUserName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.post_office_logo_png_4;
            this.pictureBox1.Location = new System.Drawing.Point(62, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // loginFormBindingSource
            // 
            this.loginFormBindingSource.DataSource = typeof(WindowsFormsApplication2.loginForm);
            // 
            // loginForm
            // 
            this.AcceptButton = this.doLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.QuitProgram;
            this.ClientSize = new System.Drawing.Size(476, 572);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button QuitProgram;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource loginFormBindingSource;
        public System.Windows.Forms.Button doLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

