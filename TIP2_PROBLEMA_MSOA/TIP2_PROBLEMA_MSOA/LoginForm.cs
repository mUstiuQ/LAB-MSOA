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

namespace TIP2_PROBLEMA_MSOA
{
    public partial class LoginForm : Form
    {

        public string path = @"C:\Users\LENOVO\source\repos\TIP2_PROBLEMA_MSOA\Autentificare.txt";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //butonul de login
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(','); //in fiser pune , intre username si parola
                    if (parts[0] == textBox1.Text && parts[1] == textBox2.Text)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        //new Form1().Show();
                        return;
                    }
                }
                MessageBox.Show("Autentificare esuata");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea fisierului" + ex.Message);
            }
        }


            private void button2_Click(object sender, EventArgs e) //butonul cancel
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        
    }
}

//ca sa dea pop up la pagina de login intra in program.cs si editeaza ca pronirea sa fie din LoginForm nu Form1
