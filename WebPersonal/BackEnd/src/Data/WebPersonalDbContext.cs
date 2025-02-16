using Microsoft.EntityFrameworkCore;
using WebPersonal.BackEnd.src.Model.Entity;

namespace WebPersonal.BackEnd.src.Data
{
    public class WebPersonalDbContext : DbContext
    {
        public DbSet<ProfileEntity> Profile { get; set; }

        public DbSet<ProjectEntity> Projects { get; set; } 

        public DbSet<EducationEntity> Educations { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public WebPersonalDbContext(DbContextOptions<WebPersonalDbContext> options) : base(options) { }
           
        
        
    }
}
