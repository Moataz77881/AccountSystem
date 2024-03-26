using AccountSystem.DataAccess.Repository.Cities;
using AccountSystem.Model.DTOs.CityDTO;
using AccountSystem.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountystem.Business.Services.Cities
{
    public class CityService : ICityService
    {
        private readonly ICityRepository repository;
        private readonly IMapper mapper;

        public CityService(ICityRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<CityDto> CreateCityService(CityCreationDto city)
        {
            var result = await repository.CreateCityRepo(mapper.Map<City>(city));
            return mapper.Map<CityDto>(result);
        }

        public async Task<CityDto?> DeleteCityService(int id)
        {
            var result = await repository.DeleteCityRepo(id);
            if (result == null) return null;
            return mapper.Map<CityDto>(result);
        }

        public async Task<List<CityDto>> GetAllCityService()
        {
            return mapper.Map<List<CityDto>>(await repository.GetAllCityRepo());
        }

        public async Task<CityDto?> UpdateCityService(CityCreationDto city, int id)
        {
            var result = await repository.UpdateCityRepo(mapper.Map<City>(city), id);
            if(result == null) return null;
            return mapper.Map<CityDto>(result);
        }
    }
}
