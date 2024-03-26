using AccountSystem.Model.DTOs.CityDTO;
using AccountSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.Model.DTOs.BranchDTO
{
    public class BranchDto
    {
        public int Id { get; set; }
        public string BranchName { get; set; } = null!;
        public virtual CityDto City { get; set; } = null!;
    }
}
