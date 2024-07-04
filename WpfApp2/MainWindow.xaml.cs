//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

//namespace WpfApp2
//{
//    /// <summary>
//    /// Логика взаимодействия для MainWindow.xaml
//    /// </summary>
//    public partial class MainWindow : Window
//    {
//        public MainWindow()
//        {
//            InitializeComponent();
//        }

//        private void PressOnButton(object sender, RoutedEventArgs e)
//        {
//            Button button = sender as Button;
//            if (button != null)
//            {
//                var result = MessageBox.Show("HELLO", "NAME", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
//                switch (result) {
//                    case MessageBoxResult.None:
//                        MessageBox.Show("MessageBoxResult.None");
//                        break;
//                    case MessageBoxResult.OK:
//                        MessageBox.Show("MessageBoxResult.OK");
//                        break;
//                    case MessageBoxResult.Yes:
//                        MessageBox.Show("MessageBoxResult.Yes");
//                        break;
//                    case MessageBoxResult.Cancel:
//                        MessageBox.Show("MessageBoxResult.Cancel");
//                        break;
//                    case MessageBoxResult.No:
//                        MessageBox.Show("MessageBoxResult.No");
//                        break;
//                        default:
//                        break;
//                }
//                //button.Content = "OK";
//                //Button button1 = new Button();
//                //button1.Width = 200;
//                //button1.Height = 200;
//                //button1.VerticalAlignment = VerticalAlignment.Bottom;
//                //button1.HorizontalAlignment = HorizontalAlignment.Left;
//                //MainGrid.Children.Add(button1);
//            }
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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
    public partial class MainWindow : Window
    {
        public MainWindow ()
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
            Rez.Text = "";
        }

        private void Plus(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            Rez.Text += str;
        }

        private void Minus(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            Rez.Text += str;
        }

        private void Delit(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            Rez.Text += str;
        }

        private void Mnozenije(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            Rez.Text += str;
        }

        private void Rezultat(object sender, RoutedEventArgs e)
        {
            string rezult= new DataTable().Compute(Rez.Text,null).ToString();
            Rez.Text = rezult;
        }
    }
}

