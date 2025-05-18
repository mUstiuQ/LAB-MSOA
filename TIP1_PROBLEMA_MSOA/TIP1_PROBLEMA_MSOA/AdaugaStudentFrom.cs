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

namespace TIP1_PROBLEMA_MSOA
{
    public partial class AdaugaStudentFrom : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=FacultateDB; Integrated Security=True";
        public AdaugaStudentFrom()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //butonul salveaza
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Studenti VALUES (@marca, @nume, @prenume, @grupa, @an)", con);
                cmd.Parameters.AddWithValue("@marca", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@nume", textBox2.Text);
                cmd.Parameters.AddWithValue("@prenume", textBox3.Text);
                cmd.Parameters.AddWithValue("@grupa", textBox4.Text);
                cmd.Parameters.AddWithValue("@an", int.Parse(textBox5.Text));
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Student adăugat!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //buton cancel
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
