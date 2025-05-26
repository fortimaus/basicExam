using Asp.DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp.DataBase
{
    public class DBCon : DbContext
    {
        

        public virtual DbSet<Training> Trainings { set; get; }
        public virtual DbSet<User> Users { set; get; }

        public virtual DbSet<Lesson> Lessons { set; get; }
        public virtual DbSet<User_Lesson> User_Lessons { set; get; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User_Lesson>().HasAlternateKey(ul => new { ul.userId, ul.lessonId, ul.date });

            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    login = "admin",
                    password = "admin",
                    role = Enums.UserRole.Admin,
                    trainingId = null,
                    training = null
                }
            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }
    }
}
