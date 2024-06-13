using AccountSystem.DataAccess.Repository;
using AccountSystem.Model.DTOs.CityDTO;
using AccountSystem.Models;
using AutoMapper;

namespace Accountystem.Business.Services.Cities
{
    public class CityService : ICityService
    {
		private readonly IUnitOfWork unitOfWork;

		//private readonly ICityRepository repository;
		private readonly IMapper mapper;

        public CityService(IUnitOfWork unitOfWork, IMapper mapper)
        {
			this.unitOfWork = unitOfWork;
			//this.repository = repository;
			this.mapper = mapper;
        }
        public void CreateCityService(CityCreationDto city)
        {
            unitOfWork.city.add(mapper.Map<City>(city));
            unitOfWork.complete();
        }

        public void DeleteCityService(int id)
        {
            var city = unitOfWork.city.getFristOrDefult(filterexpression : x => x.Id == id);
            unitOfWork.city.remove(city);
            unitOfWork.complete();
        }

        public List<CityDto> GetAllCityService()
        {
            return mapper.Map<List<CityDto>>(unitOfWork.city.getAll());
        }

        public void UpdateCityService(CityCreationDto city, int id)
        {
            unitOfWork.city.UpdateCityRepo(mapper.Map<City>(city), id);
            unitOfWork.complete();
        }
    }
}
