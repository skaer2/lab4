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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tasks
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void Task1Btn_Click(object sender, RoutedEventArgs e)
        {
            Task1Wnd task1Wnd = new Task1Wnd();
            task1Wnd.Show();
        }

        private void Task2Btn_Click(object sender, RoutedEventArgs e)
        {
            Task2Wnd task2Wnd = new Task2Wnd();
            task2Wnd.Show();
        }

        private void Task3Btn_Click(object sender, RoutedEventArgs e)
        {
            Task3Wnd Task3Wnd = new Task3Wnd();
            Task3Wnd.Show();
        }

        private void Task4Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Task5Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Task6Btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

