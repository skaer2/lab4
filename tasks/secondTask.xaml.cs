using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using Microsoft.Win32;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace tasks
{
    /// <summary>
    /// Логика взаимодействия для secondTask.xaml
    /// </summary>
    public partial class Task2Wnd : Window
    {
        public Task2Wnd()
        {
            InitializeComponent();
        }

        private string currentFileName;

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                FileTxtBx.Text = File.ReadAllText(openFileDialog.FileName);

            currentFileName = openFileDialog.FileName;
        }

        private void saveFileBtn_Click(object sender, RoutedEventArgs e)
        {
            if (currentFileName != null)
                File.WriteAllText(currentFileName, FileTxtBx.Text);
            else
                saveAsFileBtn_Click(sender, e);
        }

        private void saveAsFileBtn_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, FileTxtBx.Text);

            currentFileName = saveFileDialog.FileName;
        }
    }
}