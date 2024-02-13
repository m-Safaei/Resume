using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.DbContext;

namespace Resume.Infrastructure.Repository;
public class ContactUsRepository : IContactUsRepository
{
    #region Ctor

    private readonly ResumeDbContext _context;
    public ContactUsRepository(ResumeDbContext context)
    {
        _context = context;
    }

    #endregion

    public async Task AddContactUsToTheDatabase(ContactUs contact)
    {
        await _context.ContactUs.AddAsync(contact);
        await _context.SaveChangesAsync();
    }

}

