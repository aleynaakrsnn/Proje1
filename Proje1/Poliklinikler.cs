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
    public partial class Poliklinikler : Form
    {
        public Poliklinikler()
        {

            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Server =10.22.0.23;Database=M07;Integrated Security=true;");

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void Getir()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Ulistele";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Poliklinikler_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UEkle";
          
            cmd.Parameters.AddWithValue("PoliklinikAdı", textBox2.Text);
            cmd.Parameters.AddWithValue("PoliklinikUzmanSayısı", textBox3.Text);
            cmd.Parameters.AddWithValue("PoliklinikUzmanBaşkanı", textBox4.Text);
            cmd.Parameters.AddWithValue("PoliklinikBaşHemşire", textBox5.Text);
            cmd.Parameters.AddWithValue("YatakSayısı", textBox6.Text);
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
            cmd.CommandText = "Uyenile";
            cmd.Parameters.AddWithValue("PoliklinikNo", textBox1.Text);
            cmd.Parameters.AddWithValue("PoliklinikAdı", textBox2.Text);
            cmd.Parameters.AddWithValue("PoliklinikUzmanSayısı", textBox3.Text);
            cmd.Parameters.AddWithValue("PoliklinikUzmanBaşkanı", textBox4.Text);
            cmd.Parameters.AddWithValue("PoliklinikBaşHemşire", textBox5.Text);
            cmd.Parameters.AddWithValue("YatakSayısı", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Getir();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "USil";
            cmd.Parameters.AddWithValue("@PoliklinikNo", textBox9.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Getir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yazdır go = new Yazdır();
            go.Show();
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Getir();

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            textBox9.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[sec].Cells[5].Value.ToString();
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
            cmd.CommandText = "PAra";
            cmd.Parameters.AddWithValue("PoliklinikNo", textBox7.Text);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable doldur = new DataTable();
            dr.Fill(doldur);
            dataGridView1.DataSource = doldur;
            cmd.ExecuteNonQuery();
            con.Close();
          
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            Secenekler go = new Secenekler();
            go.Show();
            this.Hide();
        
    }
    }
}