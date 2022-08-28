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
    public partial class AdminUsers : Form
    {
        public AdminUsers()
        {
            InitializeComponent();
            DisplayUsers();
            clearUserTB();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\DataStock.mdf;Integrated Security=True;Connect Timeout=30");


        private void DisplayUsers()
        {
            con.Open();
            string query = "select * from UsersTB";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();

            sda.Fill(ds);
            UsersDGV.DataSource = ds.Tables[0];


            con.Close();

        }
        private void clearUserTB()
        {
            NameUser.Clear();
            MdpsUser.Clear();
            UserService.Clear();
        }
        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {
            MdpsUser.PasswordChar = '*';
            MdpsUser.UseSystemPasswordChar = false;
        }

        private void AjouterUser_Click(object sender, EventArgs e)
        {
            if (NameUser.Text == "" || MdpsUser.Text == "" || UserService.Text =="")
            {
                MessageBox.Show("Informations manquantes \n Veuillez remplir toutes les cases SVP ");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(" insert into UsersTB(UserName,Password,IdService) values (@UN, @UP, @US) ", con);
                    cmd.Parameters.AddWithValue("@UN", NameUser.Text);
                    cmd.Parameters.AddWithValue("@UP", MdpsUser.Text);
                    cmd.Parameters.AddWithValue("@US", UserService.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Utilisateur ajouté.");

                    con.Close();

                    DisplayUsers();

                    clearUserTB();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            clearUserTB();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SupprimerUser_Click(object sender, EventArgs e)
        {
            if (NameUser.Text == "" || MdpsUser.Text == "" || UserService.Text == "")
            {
                MessageBox.Show("Informations manquantes, Veuillez choisir l'utilisateur à supprimer");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(" delete from UsersTB where UserName = @UN ", con);
                    cmd.Parameters.AddWithValue("@UN", NameUser.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Utilisateur supprimé");

                    con.Close();
                    DisplayUsers();
                    clearUserTB();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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

        private void ModifierUser_Click(object sender, EventArgs e)
        {
            if(NameUser.Text == "" || MdpsUser.Text == "" || UserService.Text == "")
            {
                MessageBox.Show("Informations manquantes");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(" update UsersTB set Password = @UP,IdService= @US where UserName=@UN", con);
                    cmd.Parameters.AddWithValue("@UP", MdpsUser.Text);
                    cmd.Parameters.AddWithValue("@US", UserService.Text);
                    cmd.Parameters.AddWithValue("@UN", NameUser.Text);
                 

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Informations modifié ");

                    con.Close();
                    DisplayUsers();
                    clearUserTB();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    } }
