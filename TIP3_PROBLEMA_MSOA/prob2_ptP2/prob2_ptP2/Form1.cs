using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prob2_ptP2
{
    public partial class Form1 : Form
    {

        private bool ValidareCNP(string cnp)
        {
            if (cnp.Length != 13 || !cnp.All(char.IsDigit))
                return false;

            
            return true; //pt verificare validare cnp
        }

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("HR");
            treeView1.Nodes.Add("IT");
            treeView1.Nodes.Add("Contabilitate");
            treeView1.Nodes.Add("Intretinere");

            comboBox1.Items.AddRange(new string[] { "HR", "IT", "Contabilitate", "Intretinere" });
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!ValidareCNP(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "CNP invalid!");
                return;
            }

            if (!ValidareCNP(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "CNP invalid!");
                return;
            }

            Angajat angajat = new Angajat
            {
                Nume = textBox1.Text,
                CNP = textBox2.Text,
                ZileLucrate = int.Parse(textBox3.Text),
                SalariuPeZi = double.Parse(textBox4.Text),
                Departament = comboBox1.SelectedItem.ToString()
            };

            foreach (TreeNode nod in treeView1.Nodes)
            {
                if (nod.Text == angajat.Departament)
                {
                    nod.Nodes.Add(angajat.Nume).Tag = angajat; // stocăm angajatul în tag
                    nod.Expand();
                    break;
                }
            }

            // Afisam varsta
            MessageBox.Show($"Varsta: {angajat.Varsta} | Data nasterii: {angajat.DataNasterii.ToShortDateString()}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("angajati.txt"))
            {
                foreach (TreeNode dept in treeView1.Nodes)
                {
                    foreach (TreeNode node in dept.Nodes)
                    {
                        Angajat angajat = node.Tag as Angajat;
                        if (angajat != null)
                        {
                            sw.WriteLine($"{angajat.Nume},{angajat.CNP},{angajat.ZileLucrate},{angajat.Departament},{angajat.SalariuPeZi},{angajat.Varsta},{angajat.DataNasterii.ToShortDateString()}");
                        }
                    }
                }
            }

            MessageBox.Show("Datele au fost salvate in fisier.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Parent != null)
            {
                treeView1.SelectedNode.Remove();
            }
            else
            {
                MessageBox.Show("Selectează un angajat pentru stergere.");
            }
        }
    }
}
