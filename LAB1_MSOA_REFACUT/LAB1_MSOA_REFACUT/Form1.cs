using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1_MSOA_REFACUT
{
    public partial class Form1 : Form
    {

        private List<Student> lista = new List<Student>(); // lista pt studenti

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AfisareLista() //afisarea in lista
        {
            listBox1.Items.Clear();
            foreach (Student s in lista)
                listBox1.Items.Add(s.AfisareStudent());
        }

        private void button1_Click(object sender, EventArgs e) //butonul adauga
        {
            try
            {
                string nume = textBox1.Text;
                byte varsta = (byte)numericUpDown1.Value;
                byte an = Convert.ToByte(comboBox1.Text);

                byte[] note = new byte[5];
                note[0] = Convert.ToByte(comboBox2.Text);
                note[1] = Convert.ToByte(comboBox3.Text);
                note[2] = Convert.ToByte(comboBox4.Text);
                note[3] = Convert.ToByte(comboBox5.Text);
                note[4] = Convert.ToByte(comboBox6.Text);

                Student s = new Student(an, note, nume, varsta);
                lista.Add(s);
                AfisareLista();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Eroare la adaugare: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) // buton ordonare dupa nume
        {
            lista.Sort(new ComparaNume());
            AfisareLista();
        }

        private void button3_Click(object sender, EventArgs e) //butonul ordoanre dupa medie
        {
            lista.Sort(new ComparaMedie());
            AfisareLista();
        }

        private void button5_Click(object sender, EventArgs e) //butonul cautare dupa nume
        {
            string cautat = textBox2.Text.ToLower();
            listBox1.Items.Clear();

            foreach (Student s in lista)
                if (s.NumeStudent.ToLower().Contains(cautat))
                    listBox1.Items.Add(s.AfisareStudent());
        }

        private void button4_Click(object sender, EventArgs e) //buntonul pt afisarea studentilor din anul ales
        {
            try
            {
                byte an = Convert.ToByte(comboBox7.Text);
                listBox1.Items.Clear();

                foreach (Student s in lista)
                    if (s.AnStudiu == an)
                        listBox1.Items.Add(s.AfisareStudent());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Eroare afisare an: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e) //butonul de stergere
        {
            if(listBox1.SelectedIndex != -1)
            {
                lista.RemoveAt(listBox1.SelectedIndex);
                AfisareLista();
            }
            else
            {
                MessageBox.Show("Selecteaza un student pentru a-l putea sterge!");
            }
        }
    }
}
