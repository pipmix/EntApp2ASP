using System;
using Microsoft.EntityFrameworkCore;




namespace EntApp2.Data{

    public class SiteDataContext : DbContext{

        public SiteDataContext(DbContextOptions<SiteDataContext> options) : base(options)
        {
        }

        //public DbSet<Course> Courses { get; set; }
        //public DbSet<Enrollment> Enrollments { get; set; }
        //public DbSet<Student> Students { get; set; }



    }


}