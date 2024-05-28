using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDatabaseImplements
{
    public class FlyTodayDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseNpgsql("Host = 192.168.56.101; Port = 5432; Database = BookShopBd; Username = postgres; Password = 123456789");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
