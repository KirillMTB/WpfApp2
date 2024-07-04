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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Number1(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            Rez.Text += str;
        }

        private void Number2(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            Rez.Text += str;
        }

        private void Number3(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            Rez.Text += str;
        }

        private void Number4(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            Rez.Text += str;
        }

        private void Number5(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            Rez.Text += str;
        }

        private void Number6(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            Rez.Text += str;
        }

        private void Number7(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            Rez.Text += str;
        }

        private void Number8(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            Rez.Text += str;
        }

        private void Number9(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            Rez.Text += str;
        }

        private void Number0(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            Rez.Text += str;
        }

        private void AC(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            Rez.Text += str;
        }
    }
}
