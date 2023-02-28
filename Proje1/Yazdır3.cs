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
    public partial class Yazdır3 : Form
    {
        public Yazdır3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server =10.22.0.23;Database=M07;Integrated Security=true;");
        public void Getir()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HListele";


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Yazdır3_Load(object sender, EventArgs e)
        {
            Getir();
        }
    }
}
