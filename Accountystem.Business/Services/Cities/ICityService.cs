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
        public void CreateCityService(CityCreationDto city);
        public List<CityDto> GetAllCityService();
        public void DeleteCityService(int id);
        public void UpdateCityService(CityCreationDto city, int id);
    }
}
