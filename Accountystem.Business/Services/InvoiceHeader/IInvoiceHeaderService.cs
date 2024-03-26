using AccountSystem.Model.DTOs.InvoiceHeaderDTO;
using AccountSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountystem.Business.Services.InvoiceHeaders
{
    public interface IInvoiceHeaderService
    {
        public Task<InvoiceHeaderDto> CreateInvoiceHeaderService(InvoiceHeaderCreationDto invoiceHeader);
        public Task<List<InvoiceHeaderDto>> GetInvoiceHeaderService();
        public Task<InvoiceHeaderDto?> DeleteInvoiceHeaderService(int id);
        public Task<InvoiceHeaderDto?> UpdateInvoiceHeaderService(InvoiceHeaderUpdateDto invoiceHeader,int id);


    }
}
