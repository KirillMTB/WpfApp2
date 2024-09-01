using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using WpfApp2.ConsoleApp20_08_2024;
using WpfApp2.ConsoleApp20_08_2024.Abstract;
using WpfApp2.ConsoleApp20_08_2024.Repository;
using ConfigurationBuilder = Microsoft.Extensions.Configuration.ConfigurationBuilder;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IConfiguration Configuration { get; set; }
        public IServiceProvider ServiceProvider { get; set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
            Configuration = builder.Build();

            var conn1 = Configuration.GetConnectionString("SqlServerConnection");
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer(conn1);
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<MyDbContext>(new MyDbContext(optionsBuilder.Options));//регистрация служб, всяких там окон, контекста, базы данных и тд
            serviceCollection.AddScoped<IUserRepository, UserRepository>();
            serviceCollection.AddTransient(typeof(MainWindow));//регистрация служб, всяких там окон, контекста, базы данных и тд
            //AddSingleton - сервис, который регистрируется и для всего приложения он будет один;
            // AddScoped - возвращает один и тот же объект на протяжении всего запроса, например если юзеру выписать один и тот же айдишник
            // AddTransient - возвращает всегда разный объект, когда бы мы его не вызвали, например возвращать время и оно будет разное
            ServiceProvider = serviceCollection.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetService<MainWindow>();
            mainWindow.Show();

        }
    }

    public static class ServiceCollectionExtention
    {
        public static void AddWindows(this ServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient(typeof(MainWindow));
        }
    }
}
