using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_Models;

namespace TaskManager_DataAccess.Data
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<UserClient>().HasKey(u => new { u.UserId, u.ClientId });
            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(u => new { u.UserId, u.RoleId });
            modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(u => new { u.UserId});
            modelBuilder.Ignore<IdentityUserLogin<string>>();
            //modelBuilder.Ignore<IdentityUserRole<string>>();
          //  modelBuilder.Ignore<IdentityUserClaim<string>>();
            modelBuilder.Ignore<IdentityUserToken<string>>();
            modelBuilder.Ignore<IdentityUser<string>>();
            //modelBuilder.Ignore<ApplicationUser>();
        }
        public DbSet<Clients>       Clients { get; set; }
        public DbSet<HistoryTask>   HistoryTasks { get; set; }
        public DbSet<StatusTask>    StatusTasks { get; set; }
        //public DbSet<Tasks>         Tasks { get; set; }
        public DbSet<TaskHeader> TaskHeader { get; set; }
        public DbSet<TaskDetail> TaskDetail { get; set; }
        public DbSet<TypeTask>      TypeTasks { get; set; }
       // public DbSet<UserClient>    UserClients { get; set; }
       public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
