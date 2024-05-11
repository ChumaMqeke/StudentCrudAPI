using Microsoft.EntityFrameworkCore;
using StudentCrudAPI.Models;

namespace StudentCrudAPI.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions) 
         : base(contextOptions) 
        {
        


        }

        public DbSet<Student> Students { get; set; }

    }
}
