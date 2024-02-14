using Resume.Domain.Entities.Experience;

namespace Resume.Application.Services.Interface;
public interface IExperienceService
{
    List<Experience> GetListOfExperiences();
}

