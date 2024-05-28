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
                //optionsBuilder.UseNpgsql("Host=192.168.1.65;Port=5432;Database=FlyTodayBd;Username=tanya;Password=1234");
                optionsBuilder.UseNpgsql("Host=localHost;Port=5432;Database=FlyTodayBd;Username=postgres;Password=12345");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
