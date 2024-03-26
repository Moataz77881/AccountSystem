using AccountSystem.Models;
using Microsoft.EntityFrameworkCore;


namespace AccountSystem.DataAccess.Repository.Cashiers
{
    public class CashierRepo : ICashierRepository
    {
        private readonly ShaTaskContext context;

        public CashierRepo(ShaTaskContext context)
        {
            this.context = context;
        }
        public async Task<Cashier?> CreateCashierRepo(Cashier cashier)
        {
            var result = await context.Branches.FirstOrDefaultAsync(x => x.Id == cashier.BranchId);
            if (result == null) return null;
            await context.Cashiers.AddAsync(cashier);
            await context.SaveChangesAsync();
            return cashier;
        }

        public async Task<Cashier?> DeleteCashierRepo(int id)
        {
            var result = await context.Cashiers.FirstOrDefaultAsync(x => x.Id == id);
            if (result == null) return null;
            context.Cashiers.Remove(result);
            await context.SaveChangesAsync();
            return result;
        }

        public async Task<List<Cashier>> GetAllCashierRepo()
        {
            var result = await context.Cashiers.Include(x=>x.Branch).ThenInclude(x=>x.City).ToListAsync();
            return result;
        }

        public async Task<Cashier?> UpdateCashierRepo(Cashier cashier, int id)
        {
            var result = await context.Cashiers.FirstOrDefaultAsync(x => x.Id == id);
            if (result == null) return null;

            result.CashierName = cashier.CashierName;
            await context.SaveChangesAsync();
            return result;
        }
    }
}
