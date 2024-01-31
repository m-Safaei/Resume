#region Usings

using Microsoft.AspNetCore.Mvc;
using Resume.Presentation.Models.Entities.Education;
using Resume.Presentation.Models.ResumeDbContext;

namespace Resume.Presentation.Controllers;


#endregion
public class EducationController : Controller
{
    private readonly ResumeDbContext _context;

    #region Ctor

    public EducationController(ResumeDbContext context)
    {
        _context = context;
    }

    #endregion

    #region List of Educations
    [HttpGet]
    public IActionResult ListOfEducations()
    {
        List<Education> educations = _context.Educations.ToList();
        var education = _context.Educations.OrderBy(e=>e.Id).Last();
        return View();
    }

    #endregion

    #region Create an Education

    public IActionResult CreateEducation()
    {
        #region Create Record

        Education education = new()
        {
            EducationTitle = "Master",
            EducationDuration = "2012",
            Description = "Degree"
        };

        _context.Educations.Add(education);
        _context.SaveChanges();


        #endregion
        return View();
    }
    

    #endregion
}

