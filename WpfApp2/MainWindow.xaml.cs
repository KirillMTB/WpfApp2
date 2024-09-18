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
using System.Data;
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
using Microsoft.Extensions.DependencyInjection;
using Other1;

using WpfApp2.ConsoleApp20_08_2024;
using WpfApp2.ConsoleApp20_08_2024.Abstract;
using WpfApp2.ConsoleApp20_08_2024.Enities;
using WpfApp2.ConsoleApp20_08_2024.Exceptions;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IUserRepository _userRepository;
        private readonly ILibrarianRepository _librarianRepository;

        public MainWindow(IUserRepository userRepository, ILibrarianRepository librarianRepository)
        {
            InitializeComponent();

            emailBox.Text = "filatov@gmail.com";
            passwordBox.Text = "123456";

            _userRepository = userRepository;
            _librarianRepository = librarianRepository;
        }

        private void LoginInApplication(object sender, RoutedEventArgs e)
        {
            try
            {
                var librarian = _librarianRepository.LoginLibrarianByEmailAndPassword(emailBox.Text, passwordBox.Text);
                //save
                //MessageBox.Show("OK", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                var window = ((App)App.Current).ServiceProvider.GetService<WorkWindow>();
                window.Show();
                //window.Owner = this;
                this.Close();
            }
            catch (EntityNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (PasswordNotCorrectException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}

