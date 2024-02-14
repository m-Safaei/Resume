using Resume.Application.Services.Interface;
using Resume.Domain.Entities.Education;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implement;
public class EducationService : IEducationService
{
    private readonly IEducationRepository _educationRepository;

    public EducationService(IEducationRepository educationRepository)
    {
        _educationRepository = educationRepository;
    }

    public List<Education> GetListOfEducations()
    {
        return _educationRepository.GetListOfEducations();
    }
}

