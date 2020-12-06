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

namespace Selector
{
    public partial class Mate : Form
    {
        public Mate()
        {
            InitializeComponent();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Scoala_prof p = new Scoala_prof();
            this.Hide();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bogdan\Desktop\PoliHack\Catalog\Db\Data.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select Nota1, Nota2, Nota3, Nota4 from Note_mate where elev=@elev", con);
            cmd.Parameters.AddWithValue("@elev", Profesor.recby);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr.GetValue(0).ToString();
                textBox2.Text = dr.GetValue(1).ToString();
                textBox4.Text = dr.GetValue(2).ToString();
                textBox3.Text = dr.GetValue(3).ToString();
            }
            con.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mate_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Scoala_prof p = new Scoala_prof();
            this.Hide();
            p.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bogdan\Desktop\PoliHack\Catalog\Db\Data.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select Nota1, Nota2, Nota3, Nota4 from Note_info where elev=@elev", con);
            cmd.Parameters.AddWithValue("@elev", Profesor.recby);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr.GetValue(0).ToString();
                textBox2.Text = dr.GetValue(1).ToString();
                textBox4.Text = dr.GetValue(2).ToString();
                textBox3.Text = dr.GetValue(3).ToString();
            }
            con.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bogdan\Desktop\PoliHack\Catalog\Db\Data.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select Nota1, Nota2, Nota3, Nota4 from Note_mate where elev=@elev", con);
            cmd.Parameters.AddWithValue("@elev", Profesor.recby);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr.GetValue(0).ToString();
                textBox2.Text = dr.GetValue(1).ToString();
                textBox4.Text = dr.GetValue(2).ToString();
                textBox3.Text = dr.GetValue(3).ToString();
            }
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Scoala_prof p = new Scoala_prof();
            this.Hide();
            p.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
    }
}
