#region Usings

using Microsoft.AspNetCore.Mvc;
using Resume.Presentation.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Resume.Presentation.Models.ResumeDbContext;

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
        var mySkillsAsync =await _context.MySkills.ToListAsync();

        var mySkills = _context.MySkills.ToList();
        return View();
    }

}

