using System;
using System.Collections;
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
    /// Логика взаимодействия для TranslatorWindow.xaml
    /// </summary>
    public partial class TranslatorWindow : Window
    {
        public TranslatorWindow()
        {
            InitializeComponent();
            listt1.ItemsSource = new Demo09062024Entities().order.ToList();
        }

        private void listt1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnstatus_Click(object sender, RoutedEventArgs e)
        {
            DataBaseRepo.ChangeOrderStatus(listt1.SelectedIndex);
            listt1.ItemsSource = new Demo09062024Entities().order.ToList();

        }
    }
}
