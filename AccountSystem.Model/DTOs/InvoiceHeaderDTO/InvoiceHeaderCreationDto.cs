using AccountSystem.Model.DTOs.InvoiceDetailDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.Model.DTOs.InvoiceHeaderDTO
{
    public class InvoiceHeaderCreationDto
    {
        public string CustomerName { get; set; } = null!;
        public DateTime Invoicedate { get; set; } = DateTime.Now;
        public int? CashierId { get; set; }
        public List<InvoiceDetailCreationDto> InvoiceDetails { get; set; }


    }
}
