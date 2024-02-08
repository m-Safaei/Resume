#region Usings

using Microsoft.AspNetCore.Mvc;
using Resume.Presentation.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Resume.Application.DTOs.SiteSide.Home_Index;
using Resume.Domain.Entities.Education;
using Resume.Domain.Entities.Experience;
using Resume.Domain.Entities.MySkills;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.DbContext;

namespace Resume.Presentation.Controllers;


#endregion

public class HomeController : Controller
{
    private readonly IEducationRepository _educationRepository;
    private readonly IExperienceRepository _experienceRepository;
    private readonly IMySkillsRepository _mySkillsRepository;

    #region Ctor

    public HomeController(IEducationRepository educationRepository,
                          IExperienceRepository experienceRepository,
                          IMySkillsRepository mySkillsRepository)
    {
        _educationRepository = educationRepository;
        _experienceRepository = experienceRepository;
        _mySkillsRepository = mySkillsRepository;
    }

    #endregion


    public async Task<IActionResult> Index()
    {

        List<MySkills> mySkills = _mySkillsRepository.GetListOfMySkills();

        List<Education> educations = _educationRepository.GetListOfEducations();

        List<Experience> experiences = _experienceRepository.GetListOfExperiences();

        #region Fill Instance Model

        HomeIndexModelDTO model = new()
        {
            Educations = educations,
            Experiences = experiences,
            MySkills = mySkills
        };

        #endregion
        //ViewBag() , ViewData[], TempData[] :These three do the same thing but their implementation is different. 
        //ViewBag.Experience = experiencesAsync;
        //ViewBag.MySkills = mySkillsAsync;
        //ViewBag.Educations = educationsAsync;
        return View(model);
    }

}

