﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Stock
{
     
    public partial class UsersLogin : Form
    {
        public UsersLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox2.UseSystemPasswordChar = false;
        }

        private void Mdps_login_Click(object sender, EventArgs e)
        {

        }
        AdminLogin form2 = new AdminLogin();
        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue administrateur");
            
            form2.Show();
            this.Hide();
             
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.UseWaitCursor = true;
            this.Hide();
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
