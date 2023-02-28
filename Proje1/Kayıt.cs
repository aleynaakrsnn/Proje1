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

namespace Proje1
{
    public partial class Kayıt : Form
    {
        public Kayıt()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Server =10.22.0.23;Database=M07;Integrated Security=true;");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //groupBox1.Visible = true;
            //Secenekler go = new Secenekler();
            //go.Show();
            //this.Hide();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "KLogin";
            cmd.Parameters.AddWithValue("KullanıcıAdı", textBox1.Text);
            cmd.Parameters.AddWithValue("Şifre", textBox2.Text);
            con.Open();

            SqlDataReader dr;
            dr = cmd.ExecuteReader();


            if(dr.Read())
            {
                MessageBox.Show("Tebrikler!!Başarılı giriş yaptınız.");
                Secenekler git = new Secenekler();
                git.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                textBox1.Clear();
                textBox2.Clear();
            }
            con.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }
        }

        private void Kayıt_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "KEkle";

            cmd.Parameters.AddWithValue("KullanıcıAdı", textBox3.Text);
            cmd.Parameters.AddWithValue("Şifre", textBox4.Text);
            cmd.Parameters.AddWithValue("Mail", textBox5.Text);
            cmd.Parameters.AddWithValue("Telefon", textBox6.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            //Getir();


            //Secenekler git = new Secenekler();
            //git.Show();
            //this.Hide();


        }
    }
}
