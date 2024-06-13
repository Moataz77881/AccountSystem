using AccountSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.DataAccess.Repository
{
    public interface ICityRepository : IGenericRepository<City>
    {
        public void UpdateCityRepo(City city, int id);
    }
}
