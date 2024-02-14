using Resume.Application.DTOs.SiteSide.ContactUs;

namespace Resume.Application.Services.Interface;
public interface IContactUsService
{
    Task AddNewContactUsMessage(ContactUsDTO contactUsDto);
}

