using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
    /// Логика взаимодействия для Task5Wnd.xaml
    /// </summary>
    public partial class Task5Wnd : Window
    {
        public Task5Wnd()
        {
            InitializeComponent();
        }


        private void btnOpenFile1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                FileTxtBx1.Text = File.ReadAllText(openFileDialog.FileName);

            FileName1.Text = openFileDialog.FileName;
        } 
        
        private void btnOpenFile2_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                FileTxtBx2.Text = File.ReadAllText(openFileDialog.FileName);

            FileName2.Text = openFileDialog.FileName;

        }

        private void btnComparing_Click(object sender, RoutedEventArgs e)
        {
           
            int start, end;
            string[] strArr1 =  FileTxtBx1.Text.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            string[] strArr2 = FileTxtBx2.Text.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);


            if ((FileTxtBx1.Text != null) && (FileTxtBx2.Text != null))
            {
                for (int i = 0; i < strArr1.Length; i++)
                {
                    for (int j = 0; j < strArr1[i].Length; j++)
                        if strArr1[i][j]
                }
                   


                        
                      

            }   
      

        }
    }
}
