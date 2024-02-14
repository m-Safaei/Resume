#region Usings

using Microsoft.AspNetCore.Mvc;
using Resume.Presentation.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Resume.Application.DTOs.SiteSide.Home_Index;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.Education;
using Resume.Domain.Entities.Experience;
using Resume.Domain.Entities.MySkills;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.DbContext;

namespace Resume.Presentation.Controllers;


#endregion

public class HomeController : Controller
{

    #region Ctor
    private readonly IDashboardService _dashboardService;

    public HomeController(IDashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    #endregion


    public async Task<IActionResult> Index()
    {

        var model = await _dashboardService.FillDashboardModel();

        return View(model);
    }

}

