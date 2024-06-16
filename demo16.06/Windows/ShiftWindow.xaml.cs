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
    /// Логика взаимодействия для ShiftWindow.xaml
    /// </summary>
    public partial class ShiftWindow : Window
    {
        public ShiftWindow()
        {
            InitializeComponent();
            UpDate();
        }
        public void UpDate()
        {
            list2.ItemsSource= new Demo09062024Entities().shift.ToList();

        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            DataBaseRepo.AddShift(new shift() {datestart=DateTime.Now, dateend=DateTime.Now });
            UpDate();

         
        }
    }
}
