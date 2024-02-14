using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAW.NivelAccesDate
{
    public class ELearnDbContext: DbContext
    {
        public ELearnDbContext()
        {
               
        }

        public ELearnDbContext(DbContextOptions<ELearnDbContext> options) : base(options)
        {
                
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<CourseSubscription> CourseSubscriptions { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

    }
}
