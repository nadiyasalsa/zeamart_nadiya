using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace zeamart_nadiya
{
    public partial class Form2 : Form
    {

        private MySqlCommand cmd;
        private DataSet ds;
        private MySqlDataAdapter da;
        private MySqlDataReader rd;

        connections koneksi = new connections();


        public Form2()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            MySqlConnection koneksi = connections.getConnection();
            koneksi.Open();

            cmd = new MySqlCommand("Select * from login where username='" + tb_username.Text + "' and password='" + tb_password.Text + "'", koneksi);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password Yang Anda Masukkan Salah");
            }
        }
    }
}
