using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MmTbx.IsEnabled = false;
        }
        private void Button_Click(object sender, RoutedEventArgs e) // Кнопка Пройти
        {
            TestWindow testWindow = new TestWindow();
            testWindow.Show();
            Close();
            testWindow.RedBtn.IsEnabled = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // Кнопка Редактировать
        {
            MmTbx.IsEnabled = true;
        }

        private void MmTbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            string flag = "123";
            if (MmTbx.Text == flag)
            {
                TestWindow testWindow = new TestWindow();
                testWindow.Show();
                Close();
                testWindow.RedBtn.IsEnabled = true;
            }
        }
    }
}
