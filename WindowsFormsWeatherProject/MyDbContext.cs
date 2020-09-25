using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsWeatherProject
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("DbConnectionString")
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
