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
    public partial class Form1 : Form
    {

        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Cloud\OneDrive\Desktop\Ex_msoa\TransportDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
        float pretCombustibilCurent = 0;
        public Form1()
        {
            InitializeComponent();
            LoadAutovehicule();
        }

        private void LoadAutovehicule()
        {
            comboBox1.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT Id, Model + ' - ' + NrInmatriculare AS Display FROM Autovehicule", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        comboBox1.Items.Add(new ComboBoxItem(reader["Display"].ToString(), (int)reader["Id"]));
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (comboBox1.SelectedItem == null) return;

            int id = ((ComboBoxItem)comboBox1.SelectedItem).Value;
            int totalKm = 0;
            float totalValoare = 0;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                var cmdCar = new SqlCommand("SELECT Consum FROM Autovehicule WHERE Id=@id", conn);
                cmdCar.Parameters.AddWithValue("@id", id);
                float consum = Convert.ToSingle(cmdCar.ExecuteScalar());

                var cmd = new SqlCommand("SELECT * FROM Expeditii WHERE AutovehiculId=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int dist = (int)reader["Distanta"];
                        float pretL = Convert.ToSingle(reader["PretCombustibilPeLitru"]);
                        float combustibilConsum = dist * consum / 100;
                        float cost = combustibilConsum * pretL;

                        var item = new ListViewItem(reader["DataExpeditiei"].ToString());
                        item.SubItems.Add(reader["Localitate"].ToString());
                        item.SubItems.Add(dist.ToString());
                        item.SubItems.Add(pretL.ToString("0.00"));
                        item.SubItems.Add(combustibilConsum.ToString("0.00") + " L");

                        listView1.Items.Add(item);

                        totalKm += dist;
                        totalValoare += cost;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddCarForm(connString).ShowDialog();
            LoadAutovehicule();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Selectează un autovehicul!");
                return;
            }
            int id = ((ComboBoxItem)comboBox1.SelectedItem).Value;
            new AddExpeditionForm(connString, id, pretCombustibilCurent).ShowDialog();
            comboBox1_SelectedIndexChanged(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Setează preț combustibil (lei/L):", "Preț combustibil", pretCombustibilCurent.ToString());
            if (float.TryParse(input, out float val))
                pretCombustibilCurent = val;
        }


        public class ComboBoxItem
        {
            public string Text;
            public int Value;
            public ComboBoxItem(string t, int v) { Text = t; Value = v; }
            public override string ToString() => Text;
        }
    }
}
