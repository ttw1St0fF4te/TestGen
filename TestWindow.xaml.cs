using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TestGenerator
{
    /// <summary>
    /// Логика взаимодействия для TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        public TestWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e) // Кнопка Выйти
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void RedBtn_Click(object sender, RoutedEventArgs e) // Кнопка Редактировать
        {
            PageFrame.Content = new TestEditorPage();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // Кнопка Пройти
        {
            string file_path = "C:\\Users\\User\\Desktop\\TestInfo.json";
            if (File.Exists(file_path))
            {   
                PageFrame.Content = new TestPassPage();
            }
            else
            {
                PageFrame.Content = new TestFailPage();
            }
        }
    }
}