using AGIRA_INTERVIEW_BACKEND.Models;
using Microsoft.EntityFrameworkCore;

namespace AGIRA_INTERVIEW_BACKEND.Data
{
    public class ApplicationDbContext : DbContext
    {
        //ctor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }

    }
}
