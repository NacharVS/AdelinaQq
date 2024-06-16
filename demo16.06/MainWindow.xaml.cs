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
using demo16._06.Windows;

namespace demo16._06
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        user user;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void autothbtn_Click(object sender, RoutedEventArgs e)
        {
            user = DataBaseRepo.Authorization(txtlogin.Text, txtpass.Text);
            if (user == null)
            {
                MessageBox.Show("Логин или пароль неверный");
                this.Close();
            }
            else
            {
                if (user.userroleid == 1)
                {
                    var Awindow = new AdminWindow();
                    Awindow.Show();
                    this.Close();
                }
                if (user.userroleid == 2)
                {
                    var Twindow = new TranslatorWindow();
                    Twindow.Show();
                    this.Close();

                }
                if (user.userroleid == 3)
                {
                    var Mwindow = new ManagerWindow();
                    Mwindow.Show();
                    this.Close();
                }
            }
        }
    }
}
