using AccountSystem.Model.DTOs.BranchDTO;
using AccountSystem.Model.DTOs.CashierDTO;
using AccountSystem.Model.DTOs.InvoiceDetailDTO;
using AccountSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.Model.DTOs.InvoiceHeaderDTO
{
    public class InvoiceHeaderDto
    {
        public long Id { get; set; }
        public string CustomerName { get; set; } = null!;
        public DateTime Invoicedate { get; set; }
        //public virtual BranchDto Branch { get; set; } = null!;
        public virtual CashierDto? Cashier { get; set; }
        public virtual ICollection<InvoiceDetailDto> InvoiceDetails { get; set; } = new List<InvoiceDetailDto>();
    }
}
