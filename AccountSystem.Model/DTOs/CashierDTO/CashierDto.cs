using AccountSystem.Model.DTOs.BranchDTO;
using AccountSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.Model.DTOs.CashierDTO
{
    public class CashierDto
    {
        public int Id { get; set; }

        public string CashierName { get; set; } = null!;
        public virtual BranchDto Branch { get; set; } = null!;

    }
}
