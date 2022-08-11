namespace Gestion_Stock
{
    partial class AdminLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginAdminBTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MdpsAdmin = new System.Windows.Forms.TextBox();
            this.Mdps_login = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.LoginAdminBTN);
            this.panel1.ForeColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(0, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 78);
            this.panel1.TabIndex = 0;
            // 
            // LoginAdminBTN
            // 
            this.LoginAdminBTN.BackColor = System.Drawing.Color.Linen;
            this.LoginAdminBTN.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginAdminBTN.ForeColor = System.Drawing.Color.Maroon;
            this.LoginAdminBTN.Location = new System.Drawing.Point(253, 12);
            this.LoginAdminBTN.Name = "LoginAdminBTN";
            this.LoginAdminBTN.Size = new System.Drawing.Size(164, 47);
            this.LoginAdminBTN.TabIndex = 9;
            this.LoginAdminBTN.Text = "Login";
            this.LoginAdminBTN.UseVisualStyleBackColor = false;
            this.LoginAdminBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(32, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 5);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(32, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 5);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Administrateur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MdpsAdmin
            // 
            this.MdpsAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MdpsAdmin.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MdpsAdmin.Location = new System.Drawing.Point(184, 205);
            this.MdpsAdmin.Multiline = true;
            this.MdpsAdmin.Name = "MdpsAdmin";
            this.MdpsAdmin.Size = new System.Drawing.Size(299, 44);
            this.MdpsAdmin.TabIndex = 6;
            this.MdpsAdmin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Mdps_login
            // 
            this.Mdps_login.AutoSize = true;
            this.Mdps_login.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mdps_login.Location = new System.Drawing.Point(189, 162);
            this.Mdps_login.Name = "Mdps_login";
            this.Mdps_login.Size = new System.Drawing.Size(182, 31);
            this.Mdps_login.TabIndex = 5;
            this.Mdps_login.Text = "Mot de passe :";
            this.Mdps_login.Click += new System.EventHandler(this.Mdps_login_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(663, 378);
            this.Controls.Add(this.MdpsAdmin);
            this.Controls.Add(this.Mdps_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MdpsAdmin;
        private System.Windows.Forms.Label Mdps_login;
        private System.Windows.Forms.Button LoginAdminBTN;
    }
}