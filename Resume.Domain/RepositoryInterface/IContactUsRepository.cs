using Resume.Domain.Entities.ContactUs;

namespace Resume.Domain.RepositoryInterface;


public interface IContactUsRepository
{
    Task AddContactUsToTheDatabase(ContactUs contact);
    Task AddLocationToTheDatabase(ContactUsLocation location);

}

