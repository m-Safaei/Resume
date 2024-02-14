using Resume.Application.DTOs.SiteSide.Home_Index;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.Education;
using Resume.Domain.Entities.Experience;
using Resume.Domain.Entities.MySkills;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implement;
public class DashboardService : IDashboardService
{
    #region Ctor

  
    private readonly IEducationService _educationService;
    private readonly IExperienceService _experienceService;
    private readonly IMySkillsService _mySkillsService;

    public DashboardService(IEducationService educationService,
        IExperienceService experienceService,
        IMySkillsService mySkillsService)
    {
        _educationService = educationService;
        _experienceService = experienceService;
        _mySkillsService = mySkillsService;

    }

    #endregion

    public async Task<HomeIndexModelDTO> FillDashboardModel()
    {
        List<MySkills> mySkills = _mySkillsService.GetListOfMySkills();

        List<Education> educations = _educationService.GetListOfEducations();

        List<Experience> experiences = _experienceService.GetListOfExperiences();

        #region Fill Instance Model

        HomeIndexModelDTO model = new()
        {
            Educations = educations,
            Experiences = experiences,
            MySkills = mySkills
        };

        #endregion

        return model;
    }
}

