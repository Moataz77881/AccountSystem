using AccountSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.DataAccess.Repository
{
    public interface ICashierRepository : IGenericRepository<Cashier>
    {
        public void UpdateCashierRepo(Cashier cashier, int id);
        public List<Cashier> getWithAllDependencies();
    }
}
