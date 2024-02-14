using Resume.Application.DTOs.SiteSide.Home_Index;

namespace Resume.Application.Services.Interface;
public interface IDashboardService
{
    Task<HomeIndexModelDTO> FillDashboardModel();
}

