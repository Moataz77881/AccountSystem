using AccountSystem.Models;
using Microsoft.EntityFrameworkCore;


namespace AccountSystem.DataAccess.Repository.InvoiceHeaders
{
    public class InvoiceHeaderRepository : IInvoiceHeaderRepository
    {
        private readonly ShaTaskContext context;

        public InvoiceHeaderRepository(ShaTaskContext context)
        {
            this.context = context;
        }
        public async Task<InvoiceHeader?> CreateInvoiceRepo(InvoiceHeader invoice)
        {
            var result = await context.Cashiers.FirstOrDefaultAsync(x => x.Id == invoice.CashierId);
            if (result == null) return null;
            
            await context.InvoiceHeaders.AddRangeAsync(invoice);
            await context.SaveChangesAsync();
            return invoice;
        }

        public async Task<InvoiceHeader?> DeleteInvoiceRepo(int id)
        {
            var result = await context.InvoiceHeaders.Include(x=>x.InvoiceDetails).FirstOrDefaultAsync(x => x.Id == id);
            if (result == null) return null;
            var items = result.InvoiceDetails;
            context.InvoiceDetails.RemoveRange(items);
            context.InvoiceHeaders.Remove(result);
            await context.SaveChangesAsync();
            return result;

        }

        public async Task<List<InvoiceHeader>> GetInvoiceRepo()
        {
            var result = await context.InvoiceHeaders
                .Include(x=>x.Cashier)
                .ThenInclude(x=>x.Branch)
                .ThenInclude(x=>x.City)
                .Include(x=>x.InvoiceDetails)
                .ToListAsync();
            return result;
        }

        public async Task<InvoiceHeader?> UpdateInvoiceRepo(InvoiceHeader invoice, int id)
        {
            var result = await context.InvoiceHeaders.FirstOrDefaultAsync (x => x.Id == id);
            if (result == null) return null;
            result.CustomerName = invoice.CustomerName;
            result.Invoicedate = invoice.Invoicedate;
            await context.SaveChangesAsync();
            return result;
        }
    }
}
