using Resume.Application.Services.Interface;
using Resume.Domain.Entities.Experience;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implement;
public class ExperienceService : IExperienceService
{
    private readonly IExperienceRepository _experienceRepository;

    public ExperienceService(IExperienceRepository experienceRepository)
    {
        _experienceRepository = experienceRepository;
    }

    public List<Experience> GetListOfExperiences()
    {
        return _experienceRepository.GetListOfExperiences();
    }
}

