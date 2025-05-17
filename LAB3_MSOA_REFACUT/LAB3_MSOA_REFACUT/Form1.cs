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
using Microsoft.VisualBasic;

namespace LAB3_MSOA_REFACUT
{
    public partial class Form1 : Form
    {

        private string calePrincipala = @"D:\LPF"; // faci un folder unde sa salvezi fisierele .lpf pt jucatori, de asemena ei ramanand in memorie la pornire

        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            Listeaza_echipe();
        }

        void Listeaza_echipe() //functie de accesare a path ului pentru numele echipei
        {
            comboBox1.Items.Clear();
            const string Path = @"D:\LPF";
            foreach (string director in Directory.EnumerateDirectories(Path))
            {
                comboBox1.Items.Add(new DirectoryInfo(director).Name);
            }
        }

        private void button2_Click(object sender, EventArgs e) //butonul pentru salveaza
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecteaza o echipa mai intai!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormJucator formJucator = new FormJucator();
            if (formJucator.ShowDialog() == DialogResult.OK)
            {
                //salveaza jucator in fisier
                string echipaSelectata = comboBox1.SelectedItem.ToString();
                string caleEchipa = Path.Combine(calePrincipala, echipaSelectata);

                //creaza directorul pt echipa daca nu exista
                if (!Directory.Exists(caleEchipa))
                {
                    Directory.CreateDirectory(caleEchipa);
                }

                string caleJucator = Path.Combine(caleEchipa, formJucator.CNP + ".lpf");
                File.WriteAllText(caleJucator, $"{formJucator.Nume}\n{formJucator.Post}\n{formJucator.CNP}");

                //da refresh la lista cu jucatori
                IncarcareJucatori(caleEchipa);
            }
        }

        private void IncarcareJucatori(string caleEchipa)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var fisier in Directory.EnumerateFiles(caleEchipa, "*.lpf"))
            {
                string cnp = Path.GetFileNameWithoutExtension(fisier);
                string[] dateJucator = File.ReadAllLines(fisier);

                if (dateJucator.Length >= 2)
                {
                    string nume = dateJucator[0];
                    string post = dateJucator[1];

                    Button btn = new Button();
                    btn.Text = nume;
                    btn.Width = 200;
                    btn.Tag = new Jucator(nume, post, cnp);
                    btn.Click += Btn_Click;

                    flowLayoutPanel1.Controls.Add(btn);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //butonul pentru echipa noua
        {
            string numeEchipa = Microsoft.VisualBasic.Interaction.InputBox("Introdu numele echipei: ", "Echipa noua");
            if (!string.IsNullOrWhiteSpace(numeEchipa))
            {
                string caleEchipa = Path.Combine(calePrincipala, numeEchipa);
                if (!Directory.Exists(caleEchipa))
                {
                    Directory.CreateDirectory(caleEchipa);
                    comboBox1.Items.Add(numeEchipa);
                    comboBox1.SelectedItem = numeEchipa;
                }
                else
                {
                    MessageBox.Show("Echipa exista deja!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) //incaracrea paginii de login inaintea forms-ului principal
        {
            Login form = new Login();
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //comboxoul pt echipa
        {
            if (comboBox1.SelectedItem != null)
            {
                string echipaSelectata = comboBox1.SelectedItem.ToString();
                string caleEchipa = Path.Combine(calePrincipala, echipaSelectata);

                IncarcareJucatori(caleEchipa);
            }
        }

        private void Btn_Click(object sender, EventArgs e) //cream o functie pentru butonul de afisarea a detaliilor despre jucator
        {
            Button btn = (Button)sender;
            Jucator jucator = (Jucator)btn.Tag;
            textBox1.Text = jucator.Nume;
            textBox2.Text = jucator.Post;
            textBox3.Text = jucator.CNP;
            int day = Convert.ToInt32(jucator.CNP[5].ToString() + jucator.CNP[6].ToString());
            int month = Convert.ToInt32(jucator.CNP[3].ToString() + jucator.CNP[4].ToString());
            int year = 2000 + Convert.ToInt32(jucator.CNP[1].ToString() + jucator.CNP[2].ToString());
            DateTime dataNasterii = new DateTime(year, month, day);
            dateTimePicker1.Value = dataNasterii;
            int varsta = DateTime.Now.Year - dataNasterii.Year;
            textBox4.Text = varsta.ToString();

            MessageBox.Show($"Nume: {jucator.Nume}\nCNP: {jucator.CNP}\nPost: {jucator.Post}", "Detalii jucator");
        }
    }
}
