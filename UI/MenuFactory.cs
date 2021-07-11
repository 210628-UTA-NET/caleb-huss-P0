using System.IO;
using BL;
using DL;
using DL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace UI
{
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
            //Get the configuration from the appsetting.json file
            var configuration = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsetting.json")
                        .Build();

            // Get the connectionString from appsetting
            string connectionString = configuration.GetConnectionString("Reference2DB");
            DbContextOptions<DemoDBContext> options = new DbContextOptionsBuilder<DemoDBContext>()
                .UseSqlServer(connectionString)
                .Options;

            switch (p_menu)
            {
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.CustomerMenu:
                    return new CustomerMenu();
                case MenuType.AddCustomerMenu:
                    return new AddCustomerMenu(new CustomerBL(new CustomerRepository(new DemoDBContext(options))));
                case MenuType.EmployeeLoginMenu:
                    return new EmployeeLoginMenu();
                case MenuType.EmployeeMenu:
                    return new EmployeeMenu();
                case MenuType.ViewAllCustomersMenu:
                    return new ViewAllCustomersMenu(new CustomerBL(new CustomerRepository(new DemoDBContext(options))));
                case MenuType.CustomerSearchMenu:
                    return new CustomerSearchMenu(new CustomerBL(new CustomerRepository(new DemoDBContext(options))));
                default:
                    return null;
            }
        }
    }
}