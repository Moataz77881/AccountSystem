using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.Model.DTOs.InvoiceDetailDTO
{
    public class InvoiceDetailCreationDto
    {
        public long InvoiceHeaderId { get; set; }
        public string ItemName { get; set; } = null!;
        public double ItemCount { get; set; }
        public double ItemPrice { get; set; }
    }
}
