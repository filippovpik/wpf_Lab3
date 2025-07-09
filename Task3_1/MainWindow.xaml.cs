using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task3_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }



        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            string eduForm = "Заочно";

            if (checkBox.IsChecked == true)
            {
                if (Fulltime.IsChecked == true) 
                    eduForm = "Очно";

                var selectedCourses = Courses.SelectedItems
                    .Cast<ListBoxItem>()
                    .Select(item => item.Content.ToString())
                    .ToList();
                string message = $"Студент: {myTextBox.Text}\n" +
                                 $"Факультет: {Departments.Text}\n" +                                 
                                 $"Форма обучения: {eduForm}\n" +
                                 $"Количество часов: {MySlider.Value}\n" +
                                 $"Курсы: {string.Join(",", selectedCourses)}";
                MessageBox.Show(message, "Данные отправлены");
            }
            else
            {
                MessageBox.Show("Необходимо согласие на обработку данных!");
            }


        }

        private void MySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int hours=(int)(MySlider?.Value ?? 8);
            if (Hours!=null)
                Hours.Text=hours.ToString();
        }
    }
}