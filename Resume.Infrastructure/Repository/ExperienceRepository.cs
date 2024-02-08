using Resume.Domain.Entities.Experience;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.DbContext;

namespace Resume.Infrastructure.Repository
{
    public class ExperienceRepository : IExperienceRepository
    {
        #region Ctor

        private readonly ResumeDbContext _context;

        public ExperienceRepository(ResumeDbContext context)
        {
            _context = context;
        }

        #endregion

        public List<Experience> GetListOfExperiences()
        {
            return _context.Experiences.ToList();
        }
    }
}
