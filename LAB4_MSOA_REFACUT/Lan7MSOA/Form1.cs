using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lan7MSOA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // salvare folosind btn "SAVE" de pe dvg
        private void pacientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.Radiografii' table. You can move, or remove it, as needed.
            this.radiografiiTableAdapter.Fill(this.dbDataSet.Radiografii);
            // TODO: This line of code loads data into the 'dbDataSet.Pacient' table. You can move, or remove it, as needed.
            this.pacientTableAdapter.Fill(this.dbDataSet.Pacient); // afiseaza datele din pacienti in data grid view

        }

        private void pacientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            afiasreRadiografii();
        }

        private void afiasreRadiografii()
        {
            flowLayoutPanel1.Controls.Clear(); // curatam controlul de imagini

            foreach (DataRowView drv in radiografiiBindingSource1.List)
            {
                string img = (string)drv["Imagine"];

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(200, 200);
                pictureBox.BackColor = Color.Black;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Image = Bitmap.FromFile(img);
                pictureBox.Tag = 5; // ⚠️ stocam randul asociat imaginii
                pictureBox.Click += new EventHandler(PictureBox_Click);

                flowLayoutPanel1.Controls.Add(pictureBox);
            }
        }


        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                // vreau sa il pun in flowlayoutpanel2
                flowLayoutPanel2.Controls.Clear(); // curatam controlul de imagini
                PictureBox newPictureBox = new PictureBox(); // cream un nou picturebox
                newPictureBox.Size = new Size(200, 200);
                newPictureBox.BackColor = Color.Black;
                newPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                newPictureBox.Image = pictureBox.Image; // inseram imaginea in pictureBox;
                flowLayoutPanel2.Controls.Add(newPictureBox); // adaugam pictureBox-ul in flowLayoutPanel2
                // adaugam un label cu detalii

                // adaugam detaliile de la radiografie in textbox1
                if (pictureBox.Tag is DataRowView drv)
                {
                    string data = drv["Data"].ToString();
                    string diagnostic = drv["Diagnostic"].ToString();
                  string comentarii = drv["Comentarii"].ToString();
                    textBox1.Text = "Data: " + data + Environment.NewLine + "Diagnostic: " + diagnostic + Environment.NewLine + "Comentarii: " + comentarii;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cnp = (string)((DataRowView)pacientBindingSource.Current)["CNP"];
            Form2 form2 = new Form2(cnp);

            if (form2.ShowDialog() == DialogResult.OK)
            {
                this.radiografiiTableAdapter.Fill(this.dbDataSet.Radiografii);
                afiasreRadiografii();
            }

        }

        // cautare not working
        private void buttonCautare_Click(object sender, EventArgs e)
        {
            string filterText = textBoxCautare.Text;
            if (!string.IsNullOrEmpty(filterText))
            {
                // aplicam filtrul pe baza CNP-ului
                pacientBindingSource.Filter = $"CNP LIKE '%{filterText}%'";
                // actualizam DataGridView-ul
                pacientDataGridView.Refresh();
            }
            else
            {
                // daca nu exista text in textbox, afisam toate inregistrarile
                pacientBindingSource.RemoveFilter();
            }
        }
    }
}
