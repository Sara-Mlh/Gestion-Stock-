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
    
    public partial class AdminArticles : Form
    {
        public AdminArticles()
        {
            InitializeComponent();
            DisplayArticles();
            clearArticleTB();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\DataStock.mdf;Integrated Security=True;Connect Timeout=30");


        private void DisplayArticles()
        {
            con.Open();
            string query = "select * from ArticleTB";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            //DataTable data = new DataTable();
            //sda.Fill(data);
            sda.Fill(ds);
            ArticlesDGV.DataSource = ds.Tables[0];
            //var pos = 0;
            //DisplayText(pos);

            con.Close();

        }

        public void DisplayText(int rowno)
        {
            DisplayArticles();

           // nomArtTTB.Text = data.Rows[rowno][1].ToString();
            // NomTB.Text = ds.Rows[rowno][1].ToString();
            // PrenomTB.Text = ds.Rows[rowno][2].ToString();
            // SectionTB.Text = ds.Rows[rowno][3].ToString();
            //qtArtTB.Text = data.Rows[rowno][2].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AdminHome adminhome = new AdminHome();
            adminhome.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjouterArt_Click(object sender, EventArgs e)
        {



            if (nomArtTTB.Text == "" || qtArtTB.Text == "" )
            {
                MessageBox.Show("Les cases nom de l'article et la quantité sont obligatoires \n Veuillez les remplir toutes les deux SVP ");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(" insert into ArticleTB(Designation,Quantite,Description) values (@AD, @AQ, @ADES) ", con);
                    cmd.Parameters.AddWithValue("@AD", nomArtTTB.Text);
                    cmd.Parameters.AddWithValue("@AQ", qtArtTB.Text);
                    cmd.Parameters.AddWithValue("@ADES", descArtTB.Text);
                  
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Article ajouté.");

                    con.Close();
               
                    DisplayArticles();
                    
                    clearArticleTB();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }
        private void clearArticleTB()
        {
            nomArtTTB.Clear();
            qtArtTB.Clear();
            descArtTB.Clear();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            clearArticleTB();
        }
        int key = 0;
        private void ArticlesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        

                nomArtTTB.Text = ArticlesDGV.SelectedRows[0].Cells[1].Value.ToString();
                qtArtTB.Text = ArticlesDGV.SelectedRows[0].Cells[2].Value.ToString();
                descArtTB.Text = ArticlesDGV.SelectedRows[0].Cells[3].Value.ToString();

              if(nomArtTTB.Text=="")
            {
                key = 0;
            }
              else
            {
                key = Convert.ToInt32(ArticlesDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
            
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifierArt_Click(object sender, EventArgs e)
        {
            if (nomArtTTB.Text == "" || qtArtTB.Text == "" )
            {
                MessageBox.Show("Informations manquantes");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(" update ArticleTB set Designation = @AD,Quantite= @AQ,Description = @ADES where IdArticle=@Akey", con);
                    cmd.Parameters.AddWithValue("@AD", nomArtTTB.Text);
                    cmd.Parameters.AddWithValue("@AQ", qtArtTB.Text); 
                    cmd.Parameters.AddWithValue("@ADES", descArtTB.Text);
                    cmd.Parameters.AddWithValue("@Akey", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Article mis à jour ");

                    con.Close();
                    DisplayArticles();
                    clearArticleTB();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void SupprimerArt_Click(object sender, EventArgs e)
        {
            if (nomArtTTB.Text == "" || qtArtTB.Text == "")
            {
                MessageBox.Show("Informations manquantes, Veuillez choisir l'article à supprimer");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(" delete from ArticleTB where Designation = @AD ", con);
                    cmd.Parameters.AddWithValue("@AD", nomArtTTB.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Article supprimé");

                    con.Close();
                    DisplayArticles();
                    clearArticleTB();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
      
        

        private void label5_Click(object sender, EventArgs e)
        {AdminUsers userswin = new AdminUsers();
            userswin.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminUsers userswin = new AdminUsers();
            userswin.Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminHome adminhome = new AdminHome();
            adminhome.Show();
            this.Hide();
        }
    }
}
