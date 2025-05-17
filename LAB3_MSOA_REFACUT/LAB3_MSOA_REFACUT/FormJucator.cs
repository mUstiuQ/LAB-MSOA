using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3_MSOA_REFACUT
{
    public partial class FormJucator : Form
    {

        public string Nume { get; private set; }
        public string Post { get; private set; }
        public string CNP { get; private set; }

        public FormJucator()
        {
            InitializeComponent();
        }

        private void FormJucator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //butonul pentru salveaza
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Toate campurile sunt obligatorii!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Nume = textBox1.Text;
            Post = comboBox1.Text;
            CNP = textBox3.Text;

            this.DialogResult = DialogResult.OK; //returneaza OK la inchiderea formularului
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
