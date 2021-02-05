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
using System.Text.RegularExpressions;

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

        private int GetN()
        {
            
            Regex regex = new Regex("[^0-9]+");
            if (nTxtBx.Text.Length < 1)
            {
                MessageBox.Show("Fields can't be empty");
            }
            else
            if (regex.IsMatch(nTxtBx.Text))
            {
                MessageBox.Show("Invalid input in N field. Only numbers are allowed.");
            }
            else 
            {
                return int.Parse(nTxtBx.Text);
            }

            return -1;
        }

        private string ArrayToFormattedString(List<int> array)
        {
            string result = "";

            foreach(int a in array)
            {
                result += a.ToString() + "; ";
            }

            return result;
        }

        private bool GenerateArray() //returns false if operation failed
        {
            var rand = new Random();
            var buffList = new List<int>();

            var n = GetN();
            if (n != -1)
            {
                for (int i = 0; i < n; i++)
                {
                    buffList.Add(rand.Next(50) - 25);
                }
                randomArr = buffList;
                return true;
            }
            randomArr = buffList;
            return false;
        }

        private void GenerateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (GenerateArray())
                resultTxtBx.Text = ArrayToFormattedString(randomArr);
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            var mStream = new MemoryStream();
            var binFormatter = new BinaryFormatter();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Random array files (*.rarr)|*.rarr";
            if (openFileDialog.ShowDialog() == true)
            {
                var bytes = File.ReadAllBytes(openFileDialog.FileName);
                mStream.Write(bytes, 0, bytes.Length);
                mStream.Position = 0;
                randomArr = binFormatter.Deserialize(mStream) as List<int>;
                resultTxtBx.Text = ArrayToFormattedString(randomArr);
            }
        }

        private void saveFileBtn_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Random array files (*.rarr)|*.rarr";

            var binFormatter = new BinaryFormatter();
            var mStream = new MemoryStream();
            binFormatter.Serialize(mStream, randomArr);

            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllBytes(saveFileDialog.FileName, mStream.ToArray());
        }
    }
}
