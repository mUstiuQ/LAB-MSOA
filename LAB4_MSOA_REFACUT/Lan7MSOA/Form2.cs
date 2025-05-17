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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string cnp)
        {
            InitializeComponent();
            cNPTextBox.Text = cnp;
        }

        private void radiografiiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.radiografiiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.Radiografii' table. You can move, or remove it, as needed.
            this.radiografiiTableAdapter.Fill(this.dbDataSet.Radiografii);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            radiografiiTableAdapter.Insert(cNPTextBox.Text, imagineTextBox.Text,
                dataDateTimePicker.Value, diagnosticTextBox.Text, comentariiTextBox.Text); // inseram o noua inregistrare in baza de date

            // salvarea datelor introduse
            this.Validate();
            this.radiografiiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);

            this.DialogResult = DialogResult.OK;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagineTextBox.Text = openFileDialog1.FileName;
            }
        }
    }
}
