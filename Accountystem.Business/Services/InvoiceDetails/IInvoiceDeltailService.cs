using AccountSystem.Model.DTOs.InvoiceDetailDTO;


namespace Accountystem.Business.Services.InvoiceDetails
{
    public interface IInvoiceDeltailService
    {
        public List<InvoiceDetailDto> GetItemsService();
        public void UpdateItemService(InvoiceUpdateDetailDto item,int id);

    }
}
