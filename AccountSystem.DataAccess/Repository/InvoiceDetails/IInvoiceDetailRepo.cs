using AccountSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.DataAccess.Repository.InvoiceDetails
{
    public interface IInvoiceDetailRepo
    {
        public Task<List<InvoiceDetail>> GetItemDetailRepo();
        public Task<InvoiceDetail?> UpdateItemDetailRepo(InvoiceDetail item, int id);

    }
}
