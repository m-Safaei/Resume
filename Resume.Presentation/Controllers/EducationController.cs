#region Usings

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.Education;


namespace Resume.Presentation.Controllers;


#endregion
public class EducationController : Controller
{
    private readonly IEducationService _educationService;

    #region Ctor

    public EducationController(IEducationService educationService)
    {
        _educationService = educationService;
    }

    #endregion

    #region List of Educations
    [HttpGet]
    public async Task<IActionResult> ListOfEducations()
    {
        List<Education> educations = await _educationService
                                            .GetListOfEducationsAsync();
        return View(educations);
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

