using Resume.Domain.Entities.Education;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.DbContext;

namespace Resume.Infrastructure.Repository
{
    public class EducationRepository : IEducationRepository
    {
        #region Ctor

        private readonly ResumeDbContext _context;

        public EducationRepository(ResumeDbContext context)
        {
            _context = context;
        }

        #endregion

        public List<Education> GetListOfEducations()
        {
            return _context.Educations.ToList();
        }
    }
}
