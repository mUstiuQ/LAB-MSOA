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

namespace LAB3_MSOA_REFACUT
{
    public partial class Login : Form
    {

        private Timer timer;
        private int progressValue = 0;
        private string credentialsPath = @"D:\LPF\acc.txt";

        public Login()
        {
            InitializeComponent();

            textBox2.PasswordChar = '*'; //ascunde parola
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e) //functie de timer pentru miscarea progresiva a barei de incarcare
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
            }
            else
            {
                timer.Stop();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e) //butonul ok
        {
            button1.Enabled = false;
            button2.Enabled = false;

            progressBar1.Value = 0;
            timer.Start();

            await Task.Delay(2000);

            timer.Stop();
            progressBar1.Value = 100;

            if (CheckLogin(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("Autentificare reusita!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBar1.Value = 0;
                button1.Enabled = true;
                button2.Enabled = true;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void timer1_Tick(object sender, EventArgs e) //setarea timerului
        {
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }

        private bool CheckLogin(string username, string password) // functie pentru citirea parolelor din fisier 
        {
            // return username == "david" && password == "1234"; //hardcodare pentru un login mai simplu (aici e varianta simpla care o hardcodezi , i dai un return si ceau XD)
            try
            {
                if (!File.Exists(credentialsPath))
                {
                    MessageBox.Show("Fisierul de autentificare nu exista!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                string[] lines = File.ReadAllLines(credentialsPath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2 &&
                        parts[0].Trim().Equals(username, StringComparison.OrdinalIgnoreCase) &&
                        parts[1].Trim() == password)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la citirea fisierului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
