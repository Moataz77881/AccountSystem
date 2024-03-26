using AccountSystem.Model.DTOs.CashierDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountystem.Business.Services.CashierServices
{
    public interface ICashierService
    {
        public Task<CashierDto?> CreateCashierService(CashierCreationDto cashier);
        public Task<List<CashierDto>> GetAllCashierService();
        public Task<CashierDto?> UpdateCashierService(CashierUpdateDto cashier, int id);
        public Task<CashierDto?> DeleteCashierService(int id);



    }
}
