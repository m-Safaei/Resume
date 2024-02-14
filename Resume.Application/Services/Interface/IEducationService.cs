using Resume.Domain.Entities.Education;

namespace Resume.Application.Services.Interface;
public interface IEducationService
{
    List<Education> GetListOfEducations();
}

