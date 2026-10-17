using Microsoft.EntityFrameworkCore;
using StudentPortal.Models;


namespace StudentPortal.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<StudentModel> students { get; set; }
    }
}
