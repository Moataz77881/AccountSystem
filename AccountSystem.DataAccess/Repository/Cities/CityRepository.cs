using AccountSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.DataAccess.Repository.Cities
{
    public class CityRepository : ICityRepository
    {
        private readonly ShaTaskContext context;

        public CityRepository(ShaTaskContext context)
        {
            this.context = context;
        }
        public async Task<City> CreateCityRepo(City city)
        {
            await context.Cities.AddAsync(city);
            await context.SaveChangesAsync();
            return city;
        }

        public async Task<City?> DeleteCityRepo(int id)
        {
            var result = await context.Cities.FirstOrDefaultAsync(x => x.Id == id);
            if (result == null) return null;
            context.Cities.Remove(result);
            await context.SaveChangesAsync();
            return result;
        }

        public async Task<List<City>> GetAllCityRepo()
        {
            return await context.Cities.ToListAsync();
        }

        public async Task<City?> UpdateCityRepo(City city, int id)
        {
            var result = await context.Cities.FirstOrDefaultAsync(x => x.Id == id);
            if (result == null) return null;
            result.CityName = city.CityName;
            await context.SaveChangesAsync();
            return result;
        }
    }
}
