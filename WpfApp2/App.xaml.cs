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
using WpfApp2.ConsoleApp20_08_2024.Enities;
using WpfApp2.ConsoleApp20_08_2024.Repository;
using ConfigurationBuilder = Microsoft.Extensions.Configuration.ConfigurationBuilder;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IConfiguration Configuration { get; set; }
        public IServiceProvider ServiceProvider { get; set; }
        public Librarian Librarian { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            var conn = Configuration.GetConnectionString("SqlServerConnection");
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer(conn);

            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton(new MyDbContext(optionsBuilder.Options));
            serviceCollection.AddRepositories();
            serviceCollection.AddWindows();

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
            serviceCollection.AddTransient(typeof(BookWindow));
            serviceCollection.AddTransient(typeof(WorkWindow));

        }

        public static void AddRepositories(this ServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUserRepository, UserRepository>();
            serviceCollection.AddScoped<IAuthorRepository, AuthorRepository>();
            serviceCollection.AddScoped<ILibrarianRepository, LibrarianRepository>();
            serviceCollection.AddScoped<IBookRepository, BookRepository>();
        }
    }
}
