using AccountSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.Model.DTOs.BranchDTO
{
    public class CreationBranchDto
    {
        public string BranchName { get; set; } = null!;
        public int CityId { get; set; }

    }
}
