#region Usings

using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interface;

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

