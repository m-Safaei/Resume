using Resume.Domain.Entities.MySkills;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.DbContext;

namespace Resume.Infrastructure.Repository
{
    public class MySkillsRepository : IMySkillsRepository
    {
        #region Ctor

        private readonly ResumeDbContext _context;

        public MySkillsRepository(ResumeDbContext context)
        {
            _context = context;
        }

        #endregion

        public List<MySkills> GetListOfMySkills()
        {
            return _context.MySkills.ToList();
        }
    }
}
