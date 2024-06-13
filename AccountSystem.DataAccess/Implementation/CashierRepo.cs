using AccountSystem.DataAccess.Repository;
using AccountSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AccountSystem.DataAccess.Implementation
{
    public class CashierRepo : GenericRepository<Cashier>, ICashierRepository
    {
        private readonly ShaTaskContext context;

        public CashierRepo(ShaTaskContext context) : base(context)
        {
            this.context = context;
        }

        public List<Cashier> getWithAllDependencies ()
		{
            return context.Cashiers.Include(x => x.Branch).ThenInclude(x=>x.City).ToList();
		}

		public void UpdateCashierRepo(Cashier cashier, int id)
        {
            var result = context.Cashiers.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                result.CashierName = cashier.CashierName;
            }
        }
    }
}
