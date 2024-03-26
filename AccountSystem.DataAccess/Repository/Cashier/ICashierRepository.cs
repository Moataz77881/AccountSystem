using AccountSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.DataAccess.Repository.Cashiers
{
    public interface ICashierRepository
    {
        public Task<Cashier?> CreateCashierRepo(Cashier cashier);
        public Task<List<Cashier>> GetAllCashierRepo();
        public Task<Cashier?> DeleteCashierRepo(int id);
        public Task<Cashier?> UpdateCashierRepo(Cashier cashier, int id);
    }
}
