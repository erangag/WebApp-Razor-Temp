using Microsoft.EntityFrameworkCore;
using System;

namespace WebApp_Razor_Temp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}
