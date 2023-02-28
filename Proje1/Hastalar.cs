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
    public partial class Hastalar : Form
    {
        public Hastalar()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server =10.22.0.23;Database=M07;Integrated Security=true;");

        public void Getir()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Hlistele";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Getir();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HEkle";
            cmd.Parameters.AddWithValue("HastaNo", textBox1.Text);
            cmd.Parameters.AddWithValue("HastaAdSoyad", textBox2.Text);
            cmd.Parameters.AddWithValue("HastaTCNo", textBox3.Text);
            cmd.Parameters.AddWithValue("DoğumTarihi", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("Boy", textBox5.Text);
            cmd.Parameters.AddWithValue("Yaş", textBox6.Text);
            cmd.Parameters.AddWithValue("Reçete", textBox7.Text);
            cmd.Parameters.AddWithValue("RaporDurumu", textBox8.Text);
            cmd.Parameters.AddWithValue("RandevuTarihi", maskedTextBox2.Text);
            cmd.Parameters.AddWithValue("DoktorNo", comboBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Getir();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HYenile";
            cmd.Parameters.AddWithValue("HastaNo", textBox1.Text);
            cmd.Parameters.AddWithValue("HastaAdSoyad", textBox2.Text);
            cmd.Parameters.AddWithValue("HastaTCNo", textBox3.Text);
            cmd.Parameters.AddWithValue("DoğumTarihi", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("Boy", textBox5.Text);
            cmd.Parameters.AddWithValue("Yaş", textBox6.Text);
            cmd.Parameters.AddWithValue("Reçete", textBox7.Text);
            cmd.Parameters.AddWithValue("RaporDurumu", textBox8.Text);
            cmd.Parameters.AddWithValue("RandevuTarihi", maskedTextBox2.Text);
            cmd.Parameters.AddWithValue("DoktorNo", comboBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yazdır3 go = new Yazdır3();
            go.Show();
            this.Hide();
        }

        private void Hastalar_Load(object sender, EventArgs e)
        {
            //dataGridView1.Visible = false;
            //comboBox1.Enabled = false;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DoktorNoSec";

            SqlDataReader dr;

            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["DoktorNo"]);
            }
            con.Close();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HAra";
            cmd.Parameters.AddWithValue("HastaNo", textBox11.Text);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable doldur = new DataTable();
            dr.Fill(doldur);
            dataGridView1.DataSource = doldur;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Secenekler go = new Secenekler();
            go.Show();
            this.Hide();
        }
    }
}
