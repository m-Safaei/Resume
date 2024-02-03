#region Usings

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public async Task<IActionResult> ListOfEducations()
    {
        List<Education> educations = await _context.Educations.ToListAsync();
        return View();
    }

    #endregion

    #region Create an Education

    public async Task<IActionResult> CreateEducation()
    {
        #region Fill Education Instace

        Education education = new()
        {
            EducationDuration = "2022-2023",
            EducationTitle = "Military",
            Description = "That was ... "
        };

        #endregion

        #region Add Record to the Database

        await _context.Educations.AddAsync(education);
        await _context.SaveChangesAsync();


        #endregion
        return RedirectToAction(nameof(ListOfEducations));
    }


    #endregion

    #region Delete An Education

    public async Task<IActionResult> DeleteAnEducation(int educationId)
    {
        Education? education = await _context.Educations
                                     .FirstOrDefaultAsync(p => 
                                                          p.Id == educationId);
        _context.Educations.Remove(education);
        await _context.SaveChangesAsync(); 

        return RedirectToAction(nameof(ListOfEducations));
    }


    #endregion
}

