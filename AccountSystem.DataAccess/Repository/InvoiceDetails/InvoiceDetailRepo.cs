using AccountSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.DataAccess.Repository.InvoiceDetails
{
    public class InvoiceDetailRepo : IInvoiceDetailRepo
    {
        private readonly ShaTaskContext context;

        public InvoiceDetailRepo(ShaTaskContext context)
        {
            this.context = context;
        }
        public async Task<InvoiceDetail?> CreateItemDetailRepo(InvoiceDetail item)
        {
            var result = await context.InvoiceHeaders.FirstOrDefaultAsync(x => x.Id == item.InvoiceHeaderId);
            if (result == null) return null;
            await context.InvoiceDetails.AddAsync(item);
            await context.SaveChangesAsync();
            return item;
        }

        public async Task<InvoiceDetail?> DeleteItemDetailRepo(int id)
        {
            var result = await context.InvoiceDetails.FirstOrDefaultAsync(x => x.Id == id);
            if (result == null) return null;
            context.InvoiceDetails.Remove(result);
            await context.SaveChangesAsync();
            return result;
        }

        public async Task<List<InvoiceDetail>> GetItemDetailRepo()
        {
            return await context.InvoiceDetails.ToListAsync();
        }

        public async Task<InvoiceDetail?> UpdateItemDetailRepo(InvoiceDetail item, int id)
        {
            var result = await context.InvoiceDetails.FirstOrDefaultAsync(x => x.Id == id);
            if (result == null) return null;
            result.ItemName = item.ItemName;
            result.ItemCount = item.ItemCount;
            result.ItemPrice = item.ItemPrice;
            await context.SaveChangesAsync();
            return result;
        }
    }
}
