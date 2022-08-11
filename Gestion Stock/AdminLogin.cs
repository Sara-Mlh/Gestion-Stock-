using System;
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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            LoginAdminBTN.BackColor = Color.Black;

           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            /*Microsoft YaHei UI; 19,8pt; style=Bold*/
        }
    }
}
