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
using WpfApp2.ConsoleApp20_08_2024;
using WpfApp2.ConsoleApp20_08_2024.Abstract;
using WpfApp2.ConsoleApp20_08_2024.Enities;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MyDbContext _context;
        private IUserRepository _userRepository;
        public MainWindow(MyDbContext context, IUserRepository userRepository)// теперь, так как MyDbContext зарегистрирован как служба в АПП, мы можем вызвать его в любом конструкторе
        {
            InitializeComponent();
            _context = context;
            _userRepository = userRepository;
        }

        private void PressStartApplication(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                var result = MessageBox.Show("HELLO", "NAME", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                switch (result)
                {
                    case MessageBoxResult.None:
                        MessageBox.Show("MessageBoxResult.None");
                        break;
                    case MessageBoxResult.OK:
                        MessageBox.Show("MessageBoxResult.OK");
                        break;
                    case MessageBoxResult.Yes:
                        MessageBox.Show("MessageBoxResult.Yes");
                        break;
                    case MessageBoxResult.Cancel:
                        MessageBox.Show("MessageBoxResult.Cancel");
                        break;
                    case MessageBoxResult.No:
                        MessageBox.Show("MessageBoxResult.No");
                        break;
                    default:
                        break;
                }
                //button.Content = "OK";
                //Button button1 = new Button();
                //button1.Width = 200;
                //button1.Height = 200;
                //button1.VerticalAlignment = VerticalAlignment.Bottom;
                //button1.HorizontalAlignment = HorizontalAlignment.Left;
                //MainGrid.Children.Add(button1);
            }
        }

        private void emailBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CreateUser(object sender, RoutedEventArgs e)
        {
            User user = new User() //создаем таблички
            {
                Name = nameBox.Text,
                Password = passwordBox.Text,
                Email = emailBox.Text,
                BirthDay = DateTime.UtcNow,
            };
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        private void FindUser(object sender, RoutedEventArgs e)
        {
            //var user = _context.Users.FirstOrDefault(x => x.Id == int.Parse(idBox.Text));
            var user = _userRepository.GetUserById(int.Parse(idBox.Text)); 
            if (user != null)
            {
                MessageBox.Show($"User: Id ({user.Id}), Name ({user.Name}), Email ({user.Email})");
            }
            else
            {
                MessageBox.Show("User not found", "Info", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            //user.Email += ".com";
            _context.SaveChanges();

        }

        private void DeleteUser(object sender, RoutedEventArgs e)
        {
            var userDelete = _context.Users.First(User => User.Id == int.Parse(idDelBox.Text));
            _context.Users.Remove(userDelete);
            _context.SaveChanges();
        }
    }
}

