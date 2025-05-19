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

namespace Model_Msoa_ex
{
    public partial class AddCarForm : Form
    {

        string connString;
        public AddCarForm()
        {
            InitializeComponent();
            
        }

        public AddCarForm(string cs)
        {
            InitializeComponent();
            connString = cs;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Model necesar!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                var cmd = new SqlCommand("INSERT INTO Autovehicule (Model, NrInmatriculare, KmTotal, Consum, TipCombustibil) VALUES (@m,@n,@k,@c,@t)", conn);
                cmd.Parameters.AddWithValue("@m", textBox1.Text);
                cmd.Parameters.AddWithValue("@n", textBox2.Text);
                cmd.Parameters.AddWithValue("@k", textBox3.Text);
                cmd.Parameters.AddWithValue("@c", textBox4.Text);
                cmd.Parameters.AddWithValue("@t", textBox5.Text);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Autovehicul adăugat!");
            Close();
        }
    }
    
}
