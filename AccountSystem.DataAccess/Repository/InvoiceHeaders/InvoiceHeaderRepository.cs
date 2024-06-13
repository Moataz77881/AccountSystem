using AccountSystem.DataAccess.Implementation;
using AccountSystem.Models;
using Microsoft.EntityFrameworkCore;


namespace AccountSystem.DataAccess.Repository.InvoiceHeaders
{
    public class InvoiceHeaderRepository :GenericRepository<InvoiceHeader>, IInvoiceHeaderRepository
    {
        private readonly ShaTaskContext context;

        public InvoiceHeaderRepository(ShaTaskContext context): base(context)
        {
            this.context = context;
        }
        //public async Task<InvoiceHeader?> CreateInvoiceRepo(InvoiceHeader invoice)
        //{
        //    var result = await context.Cashiers.FirstOrDefaultAsync(x => x.Id == invoice.CashierId);
        //    if (result == null) return null;

        //    await context.InvoiceHeaders.AddRangeAsync(invoice);
        //    await context.SaveChangesAsync();
        //    return invoice;
        //}

        public void DeleteInvoiceRepo(int id)
        {
            var result = context.InvoiceHeaders.Include(x => x.InvoiceDetails).FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                var items = result.InvoiceDetails;
                context.InvoiceDetails.RemoveRange(items);
                context.InvoiceHeaders.Remove(result);
            }
        }

        public List<InvoiceHeader> GetInvoiceRepo()
        {
            var result = context.InvoiceHeaders
                .Include(x => x.Cashier)
                .ThenInclude(x => x.Branch)
                .ThenInclude(x => x.City)
                .Include(x => x.InvoiceDetails)
                .ToList();
            return result;
        }

        public void UpdateInvoiceRepo(InvoiceHeader invoice, int id)
        {
            var result = context.InvoiceHeaders.FirstOrDefault (x => x.Id == id);
            if (result != null) 
            {
				result.CustomerName = invoice.CustomerName;
				result.Invoicedate = invoice.Invoicedate;
			}
        }
    }
}
