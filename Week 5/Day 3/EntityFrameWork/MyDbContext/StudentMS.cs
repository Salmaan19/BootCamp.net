using EntityFrameWork.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWork.MyDbContext
{
    public class StudentMS : DbContext
    {
        public StudentMS(DbContextOptions<StudentMS> contextOptions) : base(contextOptions) { 
        
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Address> Addresses { get; set; }
    }
}

