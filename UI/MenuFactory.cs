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
            DbContextOptions<DemoDBContext> option = new DbContextOptionsBuilder<DemoDBContext>()
                .UseSqlServer(connectionString)
                .Options;

            switch (p_menu)
            {

                default:
                    return null;
            }
        }
    }
}