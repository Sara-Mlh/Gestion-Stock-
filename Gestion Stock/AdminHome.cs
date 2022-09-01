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

namespace Gestion_Stock
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\DataStock.mdf;Integrated Security=True;Connect Timeout=30");


       
        

        private void AdminHome_Load(object sender, EventArgs e)
        {
            con.Open();

            //nombre d'utilisateurs

            SqlDataAdapter sda1 = new SqlDataAdapter("Select count(*) from UsersTB", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            userstotal.Text = dt1.Rows[0][0].ToString();

            // nombre total d'articles
            SqlDataAdapter sda2 = new SqlDataAdapter("Select sum(Quantite) from ArticleTB ",con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            nbarticles.Text = dt2.Rows[0][0].ToString();

            //nombres de services

            SqlDataAdapter sda3 = new SqlDataAdapter("Select count(*) from ServiceTB", con);
            DataTable dt3= new DataTable();
            sda3.Fill(dt3);
            totalservices.Text = dt3.Rows[0][0].ToString();




            con.Close();

        }

        private void userstotal_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AdminArticles articleswind = new AdminArticles();
            articleswind.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AdminArticles articleswind = new AdminArticles();
            articleswind.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AdminServices serviceswind = new AdminServices();
            serviceswind.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AdminServices serviceswind = new AdminServices();
            serviceswind.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            AdminUsers userswin = new AdminUsers();
            userswin.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminUsers userswin = new AdminUsers();
            userswin.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nbarticles_Click_1(object sender, EventArgs e)
        {

        }
    }
}
