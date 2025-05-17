using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace LAB2_MSOA_REFACUT
{
    public partial class Form1 : Form
    {

        private List<Persoana> agenda = new List<Persoana>();
        private int index = 0;

        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(Categorie));
            //
        }

        private void Form1_Load(object sender, EventArgs e) //bagam astea ca in treeview sa se vada structura lor 
        {
            treeView1.Nodes.Add(new TreeNode("Prieteni") { Name = "Prieteni" });
            treeView1.Nodes.Add(new TreeNode("Colegi") { Name = "Colegi" });
            treeView1.Nodes.Add(new TreeNode("Rude") { Name = "Rude" });
            treeView1.Nodes.Add(new TreeNode("Diversi") { Name = "Diversi" });
        }

        private void IncarcaCategoriiTreeView()
        {
            treeView1.Nodes.Clear();
            foreach(Categorie cat in Enum.GetValues(typeof(Categorie)))
            {
                TreeNode node = new TreeNode(cat.ToString())
                {
                    Name = cat.ToString()
                };
                treeView1.Nodes.Add(node);
            }
        }

        private void button1_Click(object sender, EventArgs e) //butonul de adauga
        {
            string nume = textBox1.Text;
            DateTime dataNasterii = dateTimePicker1.Value;
            string telefon = textBox2.Text;
            string adresa = textBox3.Text;
            Categorie categorie = (Categorie)comboBox1.SelectedItem;

            Persoana p = new Persoana(index++, nume, dataNasterii, telefon, adresa, categorie);
            agenda.Add(p);

            TreeNode node = new TreeNode(p.Nume);
            treeView1.Nodes[categorie.ToString()].Nodes.Add(node);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) //afisarea pe ramuri in tree view
        {
            if(e.Node.Level == 1)
            {
                string nume = e.Node.Text;
                Persoana p = agenda.Find(x => x.Nume == nume);
                if(p!=null)
                {
                    propertyGrid1.SelectedObject = p;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) // butonul de stergere
        {
            if(treeView1.SelectedNode != null && treeView1.SelectedNode.Level == 1)
            {
                string nume = treeView1.SelectedNode.Text;
                Persoana p = agenda.Find(x => x.Nume == nume);
                if(p != null)
                {
                    if (MessageBox.Show("Doriti sa stergeti persoana [" + p.Nume + "]?", "Intrebare",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)== DialogResult.Yes)
                    {
                        agenda.Remove(p);
                        treeView1.SelectedNode.Remove();
                        propertyGrid1.SelectedObject = null;
             
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) // butonul salveaza in fisier
        {
            string dir = Application.StartupPath;
            using (StreamWriter sw = new StreamWriter(dir + "\\agenda.txt", false))
            {
                foreach(Persoana p in agenda)
                {
                    sw.WriteLine("Nume: " + p.Nume);
                    sw.WriteLine("Data Nasterii: " + p.DataNasterii);
                    sw.WriteLine("Telefon: " + p.Telefon);
                    sw.WriteLine("Adresa: " + p.Adresa);
                    sw.WriteLine("Categorie: " + p.Categorie);
                }
            }
            Process.Start("notepad.exe", dir + "\\agenda.txt");
        }

        private void button2_Click(object sender, EventArgs e) //butonul cauta
        {
            string numeCautat = textBox4.Text.Trim();
            Persoana p = agenda.Find(pers => pers.Nume.Equals(numeCautat, StringComparison.OrdinalIgnoreCase));
            if (p != null)
            {
                propertyGrid1.SelectedObject = p;
            }
            else
            {
                MessageBox.Show("Persoana nu a fsot gasita");
            }
        }
    }
}
