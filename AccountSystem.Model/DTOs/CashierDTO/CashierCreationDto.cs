using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.Model.DTOs.CashierDTO
{
    public class CashierCreationDto
    {
        public string CashierName { get; set; } = null!;
        public int BranchId { get; set; }

    }
}
