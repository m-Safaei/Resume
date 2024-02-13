#region Usings

using Microsoft.AspNetCore.Mvc;
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
    public async Task<IActionResult> ContactUs(ContactUs contact)
    {
        //Object Mapping


        //Add to the database
        await _contactUsRepository.AddContactUsToTheDatabase(contact);

        return View();
    }

    #endregion
}

