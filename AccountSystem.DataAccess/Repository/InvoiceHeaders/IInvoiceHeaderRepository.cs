using AccountSystem.Models;

namespace AccountSystem.DataAccess.Repository.InvoiceHeaders
{
    public interface IInvoiceHeaderRepository
    {
        public Task<InvoiceHeader?> CreateInvoiceRepo(InvoiceHeader invoice);
        public Task<List<InvoiceHeader>> GetInvoiceRepo();
        public Task<InvoiceHeader?> UpdateInvoiceRepo(InvoiceHeader invoice, int id);
        public Task<InvoiceHeader?> DeleteInvoiceRepo(int id);

    }
}
