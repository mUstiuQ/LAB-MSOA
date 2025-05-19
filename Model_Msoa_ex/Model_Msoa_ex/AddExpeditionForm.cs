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

    public partial class AddExpeditionForm : Form
    {

        string connString;
        int carId;
        float pret;
        public AddExpeditionForm()
        {
            InitializeComponent();
        }

        private void AddExpeditionForm_Load(object sender, EventArgs e)
        {

        }

        public AddExpeditionForm(string cs, int id, float pretCurent)
        {
            InitializeComponent();
            connString = cs;
            carId = id;
            pret = pretCurent;
            dateTimePicker1.Value = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox3, "Localitate necesară!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                var cmd = new SqlCommand("INSERT INTO Expeditii (AutovehiculId, DataExpeditiei, Distanta, Localitate, PretCombustibilPeLitru) VALUES (@a,@d,@dist,@loc,@pret)", conn);
                cmd.Parameters.AddWithValue("@a", carId);
                cmd.Parameters.AddWithValue("@d", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@dist", textBox2.Text);
                cmd.Parameters.AddWithValue("@loc", textBox3.Text);
                cmd.Parameters.AddWithValue("@pret", pret);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Expediție adăugată!");
            Close();
        }
    }
}
