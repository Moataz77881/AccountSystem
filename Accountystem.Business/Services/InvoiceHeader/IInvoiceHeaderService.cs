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
        public void CreateInvoiceHeaderService(InvoiceHeaderCreationDto invoiceHeader);
        public List<InvoiceHeaderDto> GetInvoiceHeaderService();
        public void DeleteInvoiceHeaderService(int id);
        public void UpdateInvoiceHeaderService(InvoiceHeaderUpdateDto invoiceHeader,int id);


    }
}
