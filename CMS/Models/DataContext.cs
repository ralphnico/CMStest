using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CMS.Models;
using System.ComponentModel.DataAnnotations;



namespace CMS.Models
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
   
        public DbSet<Course> Courses { get; set; }
    }
}