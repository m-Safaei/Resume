using Resume.Application.Services.Interface;
using Resume.Domain.Entities.MySkills;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implement;
public class MySkillsService : IMySkillsService
{
    private readonly IMySkillsRepository _mySkillsRepository;

    public MySkillsService(IMySkillsRepository mySkillsRepository)
    {
        _mySkillsRepository = mySkillsRepository;
    }

    public List<MySkills> GetListOfMySkills()
    {
        return _mySkillsRepository.GetListOfMySkills();
    }
}

