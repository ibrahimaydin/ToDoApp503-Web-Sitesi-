using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToDoApp503.Migrations;

namespace ToDoApp503.Models
{
    public class AppDbContext:IdentityDbContext<ApplicationUser>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Side> Sides { get; set; }
        public DbSet<ToDoItem> ToDoItems { get; set; }


        public AppDbContext():base("DefCon")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Configuration>("DefCon")); //Update işlemi yapar.
        }
        public static AppDbContext Create()
        {
            return new AppDbContext();
        }

   
    }
}