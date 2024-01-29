using Microsoft.EntityFrameworkCore;
using Resume.Presentation.Models.Entities.Education;
using Resume.Presentation.Models.Entities.Experience;
using Resume.Presentation.Models.Entities.MySkills;

namespace Resume.Presentation.Models.ResumeDbContext;

public class ResumeDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=DESKTOP-M9L4136\\SQLEXPRESS;Initial Catalog=ResumeDaneshkar;Integrated Security=True;MultipleActiveResultSets=true;Trust Server Certificate=True");
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<MySkills> MySkills { get; set; }
    public DbSet<Education> Educations { get; set; }
}

