#region Using

using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Controllers;

#endregion


public class AdminController : Controller
{
    #region Admin Dashboard

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string email,string username)
    {
        return View();
    }

    #endregion
}

