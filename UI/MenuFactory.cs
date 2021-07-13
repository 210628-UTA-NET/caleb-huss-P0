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
                case MenuType.CustomerSelectCreateMenu:
                    return new CustomerSelectCreateMenu(new CustomerBL(new CustomerRepository(new DemoDBContext(options))));
                case MenuType.CustomerStoreSelectorMenu:
                    return new CustomerStoreSelectorMenu(new StoreBL(new StoreRepository(new DemoDBContext(options))));
                case MenuType.CustomerCornerMenu:
                    return new CustomerCornerMenu();
                case MenuType.EmployeeLoginMenu:
                    return new EmployeeLoginMenu();
                    //return new ViewAllInventoryMenu(new InventoryBL(new InventoryRepository(new DemoDBContext(options))));
                
                
                default:
                    return null;
            }
        }
    }
}