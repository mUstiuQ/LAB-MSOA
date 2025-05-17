using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private Dictionary<string, string> filePaths = new Dictionary<string, string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Text files (*.txt)|*.txt"
            };

            if (ofd.ShowDialog() == true)
            {
                foreach (string path in ofd.FileNames)
                {
                    string fileName = System.IO.Path.GetFileName(path);
                    if (!filePaths.ContainsKey(fileName))
                    {
                        filePaths[fileName] = path;
                        fileListBox.Items.Add(fileName);
                    }
                }
            }
        }

        private void fileListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (fileListBox.SelectedItem == null) return;

            string fileName = fileListBox.SelectedItem.ToString();
            if (filePaths.TryGetValue(fileName, out string path))
            {
                fileContentBox.Text = File.ReadAllText(path);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveContent();
        }

        private void SaveContent()
        {
            if (fileListBox.SelectedItem == null) return;

            string fileName = fileListBox.SelectedItem.ToString();
            if (filePaths.TryGetValue(fileName, out string path))
            {
                File.WriteAllText(path, fileContentBox.Text);
                MessageBox.Show("File saved!");
            }
        }

        private void fileContentBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (chkAutosave.IsChecked == true)
            {
                SaveContent();
            }
        }
    }
}
