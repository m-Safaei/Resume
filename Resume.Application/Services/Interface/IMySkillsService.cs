using Resume.Domain.Entities.MySkills;

namespace Resume.Application.Services.Interface;
public interface IMySkillsService
{
    List<MySkills> GetListOfMySkills();
}

