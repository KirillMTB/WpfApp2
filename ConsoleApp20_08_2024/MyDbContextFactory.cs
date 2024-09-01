using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace WpfApp2.ConsoleApp20_08_2024
{
    public class MyDbContextFactory : IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args) 
        {
            //throw new NotImplementedException();
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();

            var conn1 = config.GetConnectionString("SqlServerConnection");

            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer(conn1);

            return new MyDbContext(optionsBuilder.Options);
        }
    }
}
