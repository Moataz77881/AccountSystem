using AccountSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.DataAccess.Repository.Cities
{
    public interface ICityRepository
    {
        public Task<City> CreateCityRepo(City city);
        public Task<List<City>> GetAllCityRepo();
        public Task<City?> DeleteCityRepo(int id);
        public Task<City?> UpdateCityRepo(City city, int id);
    }
}
