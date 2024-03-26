using AccountSystem.Model.DTOs.CityDTO;
using AccountSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountystem.Business.Services.Cities
{
    public interface ICityService
    {
        public Task<CityDto> CreateCityService(CityCreationDto city);
        public Task<List<CityDto>> GetAllCityService();
        public Task<CityDto?> DeleteCityService(int id);
        public Task<CityDto?> UpdateCityService(CityCreationDto city, int id);
    }
}
