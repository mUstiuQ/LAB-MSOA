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
    public partial class AdaugaMaterieForm : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=FacultateDB; Integrated Security=True";
        public AdaugaMaterieForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Materii (MarcaStudent, AnulMateriei, NumeMaterie, NotaFinala) VALUES (@marca, @an, @nume, @nota)", con);
                cmd.Parameters.AddWithValue("@marca", comboBox1.SelectedValue); // sau direct ID-ul
                cmd.Parameters.AddWithValue("@an", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@nume", textBox2.Text);
                cmd.Parameters.AddWithValue("@nota", float.Parse(textBox3.Text));
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Materie adaugata");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
