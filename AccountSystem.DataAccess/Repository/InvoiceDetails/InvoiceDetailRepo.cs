using AccountSystem.DataAccess.Implementation;
using AccountSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.DataAccess.Repository.InvoiceDetails
{
    public class InvoiceDetailRepo : GenericRepository<InvoiceDetail>, IInvoiceDetailRepo
    {
        private readonly ShaTaskContext context;

        public InvoiceDetailRepo(ShaTaskContext context):base(context)
        {
            this.context = context;
        }
        //public async Task<List<InvoiceDetail>> GetItemDetailRepo()
        //{
        //    return await context.InvoiceDetails.ToListAsync();
        //}

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
