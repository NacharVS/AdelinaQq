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
using System.Windows.Shapes;

namespace demo16._06.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        List<Employee> employees;
        public AdminWindow()
        {
            InitializeComponent();
            employees = Employee.GetEmployees();
          
        }

        private void list1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //list1.ItemsSource = 
            /*DataBaseRepo.GetUsers();*/
            ListUpDate();
        }
        private void ListUpDate()
        {
            list1.Items.Clear();
            foreach (var item in employees)
            {
                list1.Items.Add(item);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (list1.SelectedIndex >= 0)
            {
                if (employees[list1.SelectedIndex].Status != "Уволен") ;
                {
                    employees[list1.SelectedIndex].Status = "Уволен";
                    ListUpDate();
                }

            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            employees.Add(new Employee(txtlast.Text, txtfirst.Text, txtmiddle.Text, combrole.Text));
            ListUpDate();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            var window= new AdminWindow2();
            window.Show();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            var window1 = new ShiftWindow();
            window1.Show();
        }
    }
}
