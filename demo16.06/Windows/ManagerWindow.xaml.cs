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
    /// Логика взаимодействия для ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        public ManagerWindow()
        {
            InitializeComponent();
            listt2.ItemsSource = new Demo09062024Entities().order.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataBaseRepo.AddOrder(new order() { addres=txtaddres.Text, datecreation=DateTime.Now, orderstatus="готовится", paymentstatus=paystat.Text, paymentmethod=paymet.Text});
            listt2.ItemsSource = new Demo09062024Entities().order.ToList();
        }

        private void txtaddres_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
