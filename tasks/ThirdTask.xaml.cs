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
using System.Runtime.Serialization.Formatters.Binary;

namespace tasks
{
    /// <summary>
    /// Логика взаимодействия для ThirdTask.xaml
    /// </summary>
    public partial class Task3Wnd : Window
    {
        private List<int> randomArr; 

        public Task3Wnd()
        {
            InitializeComponent();

            randomArr = new List<int>();

        }

        private void GenerateBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            var binFormatter = new BinaryFormatter();
            var mStream = new MemoryStream();
            binFormatter.Serialize(mStream, randomArr);

            if (openFileDialog.ShowDialog() == true) 
                File.WriteAllBytes(openFileDialog.FileName, mStream.ToArray());
                
        }

        private void saveFileBtn_Click(object sender, RoutedEventArgs e)
        {
            var mStream = new MemoryStream();
            var binFormatter = new BinaryFormatter();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true) {
                var bytes = File.ReadAllBytes(openFileDialog.FileName);
                mStream.Write(bytes, 0, bytes.Length);
                mStream.Position = 0;
                var arr = binFormatter.Deserialize(mStream) as List<int>;
            }
                      
        }
    }
}
