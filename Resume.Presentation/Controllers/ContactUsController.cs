#region Usings

using Microsoft.AspNetCore.Mvc;
using Resume.Application.DTOs.SiteSide.ContactUs;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;

namespace Resume.Presentation.Controllers;


#endregion

public class ContactUsController : Controller
{

    #region Ctor
    private readonly IContactUsService _contactUsService;

    public ContactUsController(IContactUsService contactUsService)
    {
        _contactUsService = contactUsService;
    }

    #endregion

    #region Contact Us
    [HttpGet]
    public IActionResult ContactUs()
    {
        return View();
    }
    [HttpPost,ValidateAntiForgeryToken]
    public async Task<IActionResult> ContactUs(ContactUsDTO contactUsDto)
    {
        if (ModelState.IsValid)
        {
            await _contactUsService.AddNewContactUsMessage(contactUsDto);
            return RedirectToAction("Index", "Home");

        }


        return View();
    }

    #endregion
}

