using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_DataAccess.Data
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
        public DbSet<Clients>       Clients { get; set; }
        public DbSet<HistoryTask>   HistoryTasks { get; set; }
        public DbSet<StatusTask>    StatusTasks { get; set; }
        public DbSet<Tasks>         Tasks { get; set; }
        public DbSet<TypeTask>      TypeTasks { get; set; }
        //public DbSet<Clients> Clients { get; set; }
    }
}
