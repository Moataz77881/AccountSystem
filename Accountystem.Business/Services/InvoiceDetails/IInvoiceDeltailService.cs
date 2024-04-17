using AccountSystem.Model.DTOs.InvoiceDetailDTO;


namespace Accountystem.Business.Services.InvoiceDetails
{
    public interface IInvoiceDeltailService
    {
        public Task<List<InvoiceDetailDto>> GetItemsService();
        public Task<InvoiceDetailDto?> UpdateItemService(InvoiceUpdateDetailDto item,int id);

    }
}
