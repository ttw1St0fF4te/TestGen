using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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
using static System.Net.Mime.MediaTypeNames;

namespace TestGenerator
{
    /// <summary>
    /// Логика взаимодействия для TestPassPage.xaml
    /// </summary>
    public partial class TestPassPage : Page
    {
        public int count = 0;
        public int right = 0;
        public int wrong = 0;
        TestWindow tw = new TestWindow();

        public void AddInfo()
        {
            int countAll = test.Count();
            for (int i = 0; i < count + 1; i++)
            {
                if (count == countAll)
                {
                    if (right > wrong)
                        MessageBox.Show($"Вы прошли тест!\nПравильно: {right}\nНеправильно: {wrong}");
                    if (right < wrong)
                        MessageBox.Show($"Вы не прошли тест!\nПравильно: {right}\nНеправильно: {wrong}");
                    if (right == wrong)
                        MessageBox.Show($"Вы прошли тест!\nПравильно: {right}\nНеправильно: {wrong}");
                    tw.Close();
                    break;
                } 
                qNameTbl.Text = test[i].QuestionName;
                qInfoTbl.Text = test[i].QuestionInfo;
                fAnswerBtn.Content = test[i].FirstAnswer;
                sAnswerBtn.Content = test[i].SecondAnswer;
                tAnswerBtn.Content = test[i].ThirdAnswer;
            }
        }

        public List<Test> test = new List<Test>();


        public TestPassPage()
        {
            InitializeComponent();
            string file_path = "C:\\Users\\User\\Desktop\\TestInfo.json";
            string file = File.ReadAllText(file_path);

            test = JsonConvert.DeserializeObject<List<Test>>(file);
            AddInfo();
        }

        private void fAnswerBtn_Click(object sender, RoutedEventArgs e) // 1
        {
            if (test[count].RightAnswer == Test.RightAnswerr.FirstAnswer)
                right++;
            else
                wrong++;
            count++;
            AddInfo();
        }

        private void sAnswerBtn_Click(object sender, RoutedEventArgs e) // 2
        {
            if (test[count].RightAnswer == Test.RightAnswerr.SecondAnswer)
                right++;
            else
                wrong++;
            count++;
            AddInfo();
        }

        private void tAnswerBtn_Click(object sender, RoutedEventArgs e) // 3
        {
            if (test[count].RightAnswer == Test.RightAnswerr.ThirdAnswer)
                right++;
            else
                wrong++;
            count++;
            AddInfo();
        }
    }
}
