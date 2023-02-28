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
    public partial class Doktor : Form
    {
        public Doktor()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server =10.22.0.23;Database=M07;Integrated Security=true;");

        private void button1_Click(object sender, EventArgs e)
        {

            Yazdır2 go = new Yazdır2();
            go.Show();
            this.Hide();

        }
        public void Getir()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DListele";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DEkle";
            cmd.Parameters.AddWithValue("DoktorNo", textBox1.Text);
            cmd.Parameters.AddWithValue("DoktorAdSoyad", textBox2.Text);
            cmd.Parameters.AddWithValue("DoktorTCNo", textBox3.Text);
            cmd.Parameters.AddWithValue("UzmanlıkAlanı", textBox4.Text);
            cmd.Parameters.AddWithValue("Ünvanı", textBox5.Text);
            cmd.Parameters.AddWithValue("TelefonNumarası", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("Adres", textBox7.Text);
            cmd.Parameters.AddWithValue("DoğumTarihi", maskedTextBox2.Text);
            cmd.Parameters.AddWithValue("PoliklinikNo", textBox6.Text);
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
            cmd.CommandText = "DYenile";
            cmd.Parameters.AddWithValue("DoktorNo", textBox1.Text);
            cmd.Parameters.AddWithValue("DoktorAdSoyad", textBox2.Text);
            cmd.Parameters.AddWithValue("DoktorTCNo", textBox3.Text);
            cmd.Parameters.AddWithValue("UzmanlıkAlanı", textBox4.Text);
            cmd.Parameters.AddWithValue("Ünvanı", textBox5.Text);
            cmd.Parameters.AddWithValue("TelefonNumarası", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("Adres", textBox7.Text);
            cmd.Parameters.AddWithValue("DoğumTarihi", maskedTextBox2.Text);
            cmd.Parameters.AddWithValue("PoliklinikNo", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Getir();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Getir();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[sec].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[sec].Cells[6].Value.ToString();
            maskedTextBox2.Text = dataGridView1.Rows[sec].Cells[7].Value.ToString();
            textBox6.Text = dataGridView1.Rows[sec].Cells[8].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DAra";
            cmd.Parameters.AddWithValue("DoktorNo", textBox8.Text);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable doldur = new DataTable();
            dr.Fill(doldur);
            dataGridView1.DataSource = doldur;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            Secenekler go = new Secenekler();
            go.Show();
            this.Hide();
        }
    }
    }

