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
    public partial class AdminServices : Form
    {
        public AdminServices()
        {
            InitializeComponent();
            DisplayServices();
            clearServiceTB();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\DataStock.mdf;Integrated Security=True;Connect Timeout= 30");

        private void DisplayServices()
        {
            con.Open();
            string query = "select * from ServiceTB";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();

            sda.Fill(ds);
            ServicesDGV.DataSource = ds.Tables[0];


            con.Close();

        }
        private void clearServiceTB()
        {
            nomService.Clear();
            Designation.Clear();
            Etage.Clear();
        }
        private void descArtTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void AjouterService_Click(object sender, EventArgs e)
        {

            if (nomService.Text == "" || Designation.Text == "" || Etage.Text == "")
            {
                MessageBox.Show("Veuillez remplir toutes les cases SVP ");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(" insert into ServiceTB(IdService,Designation,NumEtage) values (@IDS, @DS, @NES) ", con);
                    cmd.Parameters.AddWithValue("@IDS", nomService.Text);
                    cmd.Parameters.AddWithValue("@DS", Designation.Text);
                    cmd.Parameters.AddWithValue("@NES", Etage.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Service ajouté.");

                    con.Close();

                    DisplayServices();

                    clearServiceTB();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            clearServiceTB();
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

        private void SupprimerService_Click(object sender, EventArgs e)
        {
            if (nomService.Text == "" || Designation.Text == "" || Etage.Text == "")
            {
                MessageBox.Show("Informations manquantes, Veuillez choisir le service à supprimer");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(" delete from ServiceTB where IdService = @IDS ", con);
                    cmd.Parameters.AddWithValue("@IDS", nomService.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Service supprimé");

                    con.Close();
                    DisplayServices();
                    clearServiceTB();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ModifierService_Click(object sender, EventArgs e)
        {
            if (nomService.Text == "" || Designation.Text == "" || Etage.Text == "")
            {
                MessageBox.Show("Informations manquantes");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(" update ServiceTB set  Designation = @DS,NumEtage= @NES where IdService=@IDS", con);
                    cmd.Parameters.AddWithValue("@DS", Designation.Text);
                    cmd.Parameters.AddWithValue("@NES", Etage.Text);
                    cmd.Parameters.AddWithValue("@IDS", nomService.Text);
                    //cmd.Parameters.AddWithValue("@IDS", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Service mis à jour ");

                    con.Close();
                    DisplayServices();
                    clearServiceTB();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //AdminServices serviceswind = new AdminServices();

        
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

        private void ServicesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomService.Text = ServicesDGV.SelectedRows[0].Cells[1].Value.ToString();
            Etage.Text = ServicesDGV.SelectedRows[0].Cells[3].Value.ToString();
            Designation.Text = ServicesDGV.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
