#region Usings

using Microsoft.AspNetCore.Mvc;
using Resume.Presentation.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities.Education;
using Resume.Domain.Entities.Experience;
using Resume.Domain.Entities.MySkills;
using Resume.Infrastructure.DbContext;

namespace Resume.Presentation.Controllers;


#endregion

public class HomeController : Controller
{

    #region Ctor

    private readonly ResumeDbContext _context;

    public HomeController(ResumeDbContext context)
    {
        _context = context;
    }

    #endregion


    public async Task<IActionResult> Index()
    {
        List<MySkills> mySkillsAsync =await _context.MySkills.ToListAsync();
        List<MySkills> mySkillsSync = _context.MySkills.ToList();

        List<Education> educationsAsync = await _context.Educations.ToListAsync();
        List<Education> educationsSync = _context.Educations.ToList();

        List<Experience> experiencesAsync = await _context.Experiences.ToListAsync();
        List<Experience> experiencesSync = _context.Experiences.ToList();

        //ViewBag() , ViewData[], TempData[] :These three do the same thing but their implementation is different. 
        //ViewBag.Experience = experiencesAsync;
        //ViewBag.MySkills = mySkillsAsync;
        //ViewBag.Educations = educationsAsync;
        return View(educationsAsync);
    }

}

