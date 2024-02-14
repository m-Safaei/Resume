#region Usings

using Resume.Application.DTOs.SiteSide.ContactUs;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implement;


#endregion
public class ContactUsService : IContactUsService
{
    #region Ctor

    private readonly IContactUsRepository _contactUsRepository;
    public ContactUsService(IContactUsRepository contactUsRepository)
    {
        _contactUsRepository = contactUsRepository;
    }


    #endregion
    public async Task AddNewContactUsMessage(ContactUsDTO contactUsDto)
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
    }
}

