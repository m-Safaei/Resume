#region Usings

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Presentation.Models.Entities.Education;
using Resume.Presentation.Models.ResumeDbContext;

namespace Resume.Presentation.Controllers;


#endregion
public class EducationController : Controller
{

    #region Ctor

    public EducationController()
    {
    }

    #endregion

    #region List of Educations
    [HttpGet]
    public async Task<IActionResult> ListOfEducations()
    {
        
        return View();
    }

    #endregion

    #region Create an Education

    public async Task<IActionResult> CreateEducation()
    {
        
        return RedirectToAction(nameof(ListOfEducations));
    }


    #endregion

    #region Delete An Education

    public async Task<IActionResult> DeleteAnEducation(int educationId)
    {
         

        return RedirectToAction(nameof(ListOfEducations));
    }


    #endregion
}

