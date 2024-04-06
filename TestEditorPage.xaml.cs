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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestGenerator
{
    /// <summary>
    /// Логика взаимодействия для TestEditorPage.xaml
    /// </summary>
    public partial class TestEditorPage : Page
    {
        public List<Test> test = new List<Test>();

        public List<Test.RightAnswerr> RightAnswerrs { get; set; } = [Test.RightAnswerr.FirstAnswer, Test.RightAnswerr.SecondAnswer, Test.RightAnswerr.ThirdAnswer];

        public TestEditorPage()
        {
            InitializeComponent();
            test.Add(new Test("", "", "", "", "", Test.RightAnswerr.FirstAnswer));
            TestDgr.ItemsSource = test;
        }

        public void CheckAndSave()
        {
            int count = test.Count();

            for (int i = 0; i < count; i++)
            {
                if (string.IsNullOrWhiteSpace(test[i].QuestionName) ||
                    string.IsNullOrWhiteSpace(test[i].QuestionInfo) ||
                    string.IsNullOrWhiteSpace(test[i].FirstAnswer) ||
                    string.IsNullOrWhiteSpace(test[i].SecondAnswer) ||
                    string.IsNullOrWhiteSpace(test[i].ThirdAnswer) ||
                    test[i].RightAnswer != Test.RightAnswerr.FirstAnswer &&
                    test[i].RightAnswer != Test.RightAnswerr.SecondAnswer &&
                    test[i].RightAnswer != Test.RightAnswerr.ThirdAnswer)
                {
                    MessageBox.Show("Не все поля заполнены");
                }
                else
                {
                    string file = JsonSerializer.Serialize(test);
                    File.WriteAllText("C:\\Users\\User\\Desktop\\TestInfo.json", file);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) // кнопка сериализации таблицы в JSON
        {
            CheckAndSave();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // кнопка добавления вопроса
        {
            CheckAndSave();
            test.Add(new Test("", "", "", "", "", Test.RightAnswerr.FirstAnswer));
            TestDgr.ItemsSource = null;
            TestDgr.ItemsSource = test;
        }
    }
}