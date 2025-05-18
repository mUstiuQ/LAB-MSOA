using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIP2_PROBLEMA_MSOA
{


    public partial class AddForm : Form
    {

        public EchipamentSport Echipament { get; private set; }
        public AddForm()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new[] { "inot", "ciclism", "fotbal" });
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //butonul ok
        {
            decimal pret;
            if (!decimal.TryParse(textBox6.Text, out pret) || pret <  0)
            {
                MessageBox.Show("Pret invalid");
                return;
            }

            Echipament = new EchipamentSport
            {
                Cod = textBox1.Text,
                Producator = textBox2.Text,
                Model = textBox3.Text,
                Descriere = textBox4.Text,
                NrBucati = (int)numericUpDown1.Value,
                Pret = pret,
                Categorie = comboBox1.SelectedItem.ToString()
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //butonul cancel
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
