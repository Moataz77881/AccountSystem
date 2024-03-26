using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.Model.DTOs.InvoiceHeaderDTO
{
    public class InvoiceHeaderUpdateDto
    {
        public string CustomerName { get; set; } = null!;
        public DateTime Invoicedate { get; set; } = DateTime.Now;

    }
}
