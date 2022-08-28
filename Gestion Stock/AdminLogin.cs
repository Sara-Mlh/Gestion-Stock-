using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Stock
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\DataStock.mdf;Integrated Security=True;Connect Timeout=30");

        DataTable data = new DataTable();
        DataSet ds = new DataSet();
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MdpsAdmin.PasswordChar = '*';
            MdpsAdmin.UseSystemPasswordChar = false;
         
        }

        private void Mdps_login_Click(object sender, EventArgs e)
        {

        }
        string nameAdmin = "ADMIN";
        AdminArticles adminArticles = new AdminArticles();
        private void button1_Click(object sender, EventArgs e)
        {
            LoginAdminBTN.BackColor = Color.Green;
            if (nameAdmin == "ADMIN" && MdpsAdmin.Text == "ADMINMDPS") /* VERIFIER DE LA BASE DE DONNEES */
            {
                
               MessageBox.Show("Connexion réussite");
                this.Hide();
                adminArticles.Show();

            }
            else
            {
                MessageBox.Show("Mot de passe erroné");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            /*Microsoft YaHei UI; 19,8pt; style=Bold*/
        }
    }
}
