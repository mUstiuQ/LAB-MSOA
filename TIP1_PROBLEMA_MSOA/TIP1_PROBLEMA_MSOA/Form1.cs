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
    public partial class Form1 : Form
    {

        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FacultateDB;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // Curățăm arborele
            treeView1.Nodes.Clear();

            // Ne conectăm la baza de date
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Luăm toți studenții
                SqlCommand cmd = new SqlCommand("SELECT * FROM Studenti", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int anul = Convert.ToInt32(reader["Anul"]);
                    string nume = reader["Nume"].ToString();
                    string prenume = reader["Prenume"].ToString();
                    int marca = Convert.ToInt32(reader["Marca"]);

                    // Căutăm sau adăugăm nodul "Anul X"
                    TreeNode anNode = null;

                    foreach (TreeNode n in treeView1.Nodes)
                        if (n.Text == $"Anul {anul}") anNode = n;

                    if (anNode == null)
                    {
                        anNode = new TreeNode($"Anul {anul}");
                        treeView1.Nodes.Add(anNode);
                    }

                    // Adăugăm studentul sub anul lui
                    TreeNode studentNode = new TreeNode($"{nume} {prenume}");
                    studentNode.Tag = marca; // Marca este cheia
                    anNode.Nodes.Add(studentNode);
                }

                reader.Close();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null)
                return;

            int marca = (int)e.Node.Tag;
            listBox1.Items.Clear();
            textBox1.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Materii WHERE MarcaStudent = @marca", con);
                cmd.Parameters.AddWithValue("@marca", marca);

                SqlDataReader reader = cmd.ExecuteReader();

                double total = 0;
                int count = 0;

                while (reader.Read())
                {
                    string materie = reader["NumeMaterie"].ToString();
                    double nota = Convert.ToDouble(reader["NotaFinala"]);
                    int an = Convert.ToInt32(reader["AnulMateriei"]);

                    listBox1.Items.Add($"{materie} - An {an} - Nota: {nota}");
                    total += nota;
                    count++;
                }

                reader.Close();

                if (count > 0)
                {
                    double medie = total / count;
                    textBox1.Text = medie.ToString("0.00");
                }
                else
                {
                    textBox1.Text = "Fără note.";
                }
            }
        }
    }
}
