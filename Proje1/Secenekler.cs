using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje1
{
    public partial class Secenekler : Form
    {
        public Secenekler()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { 
            Poliklinikler go = new Poliklinikler();
            go.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Doktor go = new Doktor();
            go.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Hastalar go = new Hastalar();
            go.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Rapor1 go = new Rapor1();
            go.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rapor3 go = new Rapor3();
            go.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rapor2 go = new Rapor2();
            go.Show();
            this.Hide();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Kayıt go = new Kayıt();
            go.Show();
            this.Hide();

        }
    }
}
