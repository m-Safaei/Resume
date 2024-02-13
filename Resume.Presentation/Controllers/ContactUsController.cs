#region Usings

using Microsoft.AspNetCore.Mvc;
using Resume.Application.DTOs.SiteSide.ContactUs;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;

namespace Resume.Presentation.Controllers;


#endregion

public class ContactUsController : Controller
{

    #region Ctor

    private readonly IContactUsRepository _contactUsRepository;
    public ContactUsController(IContactUsRepository contactUsRepository)
    {
        _contactUsRepository = contactUsRepository;
    }

    #endregion

    #region Contact Us
    [HttpGet]
    public IActionResult ContactUs()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> ContactUs(ContactUsDTO contactUsDto)
    {
        //Object Mapping
        ContactUs contact = new()
        {
            FullName = contactUsDto.FullName,
            Mobile = contactUsDto.Mobile,
            Message = contactUsDto.Message,
        };
        ContactUsLocation location = new()
        {
            Address = contactUsDto.Address,
        };

        //Add to the database
        await _contactUsRepository.AddContactUsToTheDatabase(contact);
        await _contactUsRepository.AddLocationToTheDatabase(location);

        return View();
    }

    #endregion
}

