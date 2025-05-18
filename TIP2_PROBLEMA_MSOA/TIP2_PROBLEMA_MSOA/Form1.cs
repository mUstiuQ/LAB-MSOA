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

namespace TIP2_PROBLEMA_MSOA
{
    public partial class Form1 : Form
    {

        private List<EchipamentSport> echipamente = new List<EchipamentSport>(); // cream lista pt echipamente

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AddForm addForm = new AddForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK && addForm.Echipament != null)
                {
                    echipamente.Add(addForm.Echipament);
                    UpdateFlowPanels();
                }
            }
        }

        private void UpdateFlowPanels() // cream functie pentru actualizarea panourilor de afisare
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel3.Controls.Clear();

            // adaugam butoane noi pentru fiecare echipament
            foreach (var echipament in echipamente)
            {
                Button btn = new Button
                {
                    Text = echipament.Cod,
                    Width = 100,
                    Height = 40,
                    Tag = echipament // Salvam obiectul in Tag pentru accesare ulterioara
                };

                btn.Click += (s, ev) =>
                {
                    // afisam detaliile in PropertyGrid cand se apasa butonul
                    propertyGrid1.SelectedObject = ((Button)s).Tag;
                };

                // adaugam butonul in FlowLayoutPanel-ul corespunzator
                switch (echipament.Categorie)
                {
                    case "inot": flowLayoutPanel1.Controls.Add(btn); break;
                    case "ciclism": flowLayoutPanel2.Controls.Add(btn); break;
                    case "fotbal": flowLayoutPanel3.Controls.Add(btn); break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (propertyGrid1.SelectedObject != null)
            {
                echipamente.Remove((EchipamentSport)propertyGrid1.SelectedObject);
                UpdateFlowPanels();
                propertyGrid1.SelectedObject = null; // golim PropertyGrid dupa stergere
            }
            else
            {
                MessageBox.Show("Selectați un echipament din listă!");
            }
        }
    }
}
