using Resume.Domain.Entities.Education;
using Resume.Domain.Entities.Experience;
using Resume.Domain.Entities.MySkills;

namespace Resume.Application.DTOs.SiteSide.Home_Index;

public class HomeIndexModelDTO
{
    public List<Education> Educations { get; set; }
    public List<Experience> Experiences { get; set; }
    public List<MySkills> MySkills { get; set; }
}

