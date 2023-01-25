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

namespace Diplom
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void PassTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoginTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void forgotButton_Click(object sender, RoutedEventArgs e)
        {
            Windows.ForgotWindow window = new Windows.ForgotWindow();
            this.Close();
            window.ShowDialog();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Windows.WorkWindow window = new Windows.WorkWindow();
            this.Close();
            window.ShowDialog();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            
            Windows.RegisterWindow window = new Windows.RegisterWindow();
            this.Close();
            window.ShowDialog();
            

        }
    }
}
