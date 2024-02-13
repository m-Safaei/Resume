#region Using

using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.Entities.Education;
using Resume.Domain.Entities.Experience;
using Resume.Domain.Entities.MySkills;

namespace Resume.Infrastructure.DbContext;


#endregion

public class ResumeDbContext:Microsoft.EntityFrameworkCore.DbContext
{
    #region Ctor

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=DESKTOP-M9L4136\\SQLEXPRESS;Initial Catalog=ResumeDaneshkar;Integrated Security=True;MultipleActiveResultSets=true;Trust Server Certificate=True");
        base.OnConfiguring(optionsBuilder);
    }

    #endregion

    #region DbSets

    public DbSet<Experience> Experiences { get; set; }
    public DbSet<MySkills> MySkills { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<ContactUs> ContactUs { get; set; }
    public DbSet<ContactUsLocation> Locations { get; set; }


    #endregion
}

