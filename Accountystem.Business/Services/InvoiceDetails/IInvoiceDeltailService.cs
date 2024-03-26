using AccountSystem.Model.DTOs.InvoiceDetailDTO;


namespace Accountystem.Business.Services.InvoiceDetails
{
    public interface IInvoiceDeltailService
    {
        public Task<InvoiceDetailDto?> CreateItemService(InvoiceDetailCreationDto item);
        public Task<List<InvoiceDetailDto>> GetItemsService();
        public Task<InvoiceDetailDto?> DeleteItemService(int id);
        public Task<InvoiceDetailDto?> UpdateItemService(InvoiceUpdateDetailDto item,int id);

    }
}
