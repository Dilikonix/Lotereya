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

namespace Diplom.Windows
{
    /// <summary>
    /// Логика взаимодействия для ForgotWindow.xaml
    /// </summary>
    public partial class ForgotWindow : Window
    {
        public ForgotWindow()
        {
            InitializeComponent();
        }

        private void ButtonRecoverUser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonBackLogin1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Close();
            window.ShowDialog();
        }
    }
}
