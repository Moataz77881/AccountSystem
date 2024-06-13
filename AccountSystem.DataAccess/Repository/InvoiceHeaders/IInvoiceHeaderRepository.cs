using AccountSystem.Models;

namespace AccountSystem.DataAccess.Repository.InvoiceHeaders
{
    public interface IInvoiceHeaderRepository: IGenericRepository<InvoiceHeader>
    {
        //public Task<InvoiceHeader?> CreateInvoiceRepo(InvoiceHeader invoice);
        public List<InvoiceHeader> GetInvoiceRepo();
        public void UpdateInvoiceRepo(InvoiceHeader invoice, int id);
        public void DeleteInvoiceRepo(int id);

    }
}
