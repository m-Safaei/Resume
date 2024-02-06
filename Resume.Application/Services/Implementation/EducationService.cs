#region Using

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.Education;
using Resume.Infrastructure.DbContext;

namespace Resume.Application.Services.Implementation;

#endregion


public class EducationService : IEducationService
{
    #region Ctor

    private readonly ResumeDbContext _context;
    public EducationService(ResumeDbContext context)
    {
        _context = context;
    }


    #endregion
    public async Task<List<Education>> GetListOfEducationsAsync()
    {
        List<Education> educations = await _context.Educations.ToListAsync();
        return educations;
    }
    public List<Education> GetListOfEducations()
    {
        List<Education> educations = _context.Educations.ToList();
        return educations;
    }

    public async Task CreateAnEducationAsync(Education education)
    {
        #region Fill Education Instace

        Education education1 = new()
        {
            EducationDuration = "2022-2023",
            EducationTitle = "Military",
            Description = "That was ... "
        };

        #endregion

        #region Add Record to the Database

        await _context.Educations.AddAsync(education1);
        await _context.SaveChangesAsync();


        #endregion
    }
    public void CreateAnEducation(Education education)
    {
        #region Fill Education Instace

        Education education1 = new()
        {
            EducationDuration = "2022-2023",
            EducationTitle = "Military",
            Description = "That was ... "
        };

        #endregion

        #region Add Record to the Database

        _context.Educations.Add(education1);
        _context.SaveChanges();


        #endregion
    }

    public async Task DeleteAnEducationAsync(int educationId)
    {
        Education education = await GetAnEducationByIdAsync(educationId);

        _context.Educations.Remove(education);
        await _context.SaveChangesAsync();
    }



    public void DeleteAnEducation(int educationId)
    {
        Education education = GetAnEducationById(educationId);

        _context.Educations.Remove(education);
        _context.SaveChanges();
    }

    public async Task<Education> GetAnEducationByIdAsync(int educationId)
    {
        Education? education = await _context.Educations
            .FirstOrDefaultAsync(p => p.Id == educationId);

        if (education ==null)
        {
            return null;
        }
        return education;
    }

    public Education GetAnEducationById(int educationId)
    {
        Education? education = _context.Educations
            .FirstOrDefault(p => p.Id == educationId);
        return education;
    }
}

