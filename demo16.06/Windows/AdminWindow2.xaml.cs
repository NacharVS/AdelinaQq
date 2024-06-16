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
    /// Логика взаимодействия для AdminWindow2.xaml
    /// </summary>
    public partial class AdminWindow2 : Window
    {
        public AdminWindow2()
        {
            InitializeComponent();
            list3.ItemsSource=new Demo09062024Entities().order.ToList();    
            
        }

        private void list3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
