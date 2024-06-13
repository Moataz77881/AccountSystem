using AccountSystem.DataAccess.Repository;
using AccountSystem.Models;

namespace AccountSystem.DataAccess.Implementation
{
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        private readonly ShaTaskContext context;

        public CityRepository(ShaTaskContext context) : base(context)
        {
            this.context = context;
        }
        public void UpdateCityRepo(City city, int id)
        {
            var result = context.Cities.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                result.CityName = city.CityName;
            }
        }
    }
}
