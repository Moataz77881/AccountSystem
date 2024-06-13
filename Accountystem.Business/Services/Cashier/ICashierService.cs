using AccountSystem.Model.DTOs.CashierDTO;

namespace Accountystem.Business.Services.CashierServices
{
    public interface ICashierService
    {
        public void CreateCashierService(CashierCreationDto cashier);
        public List<CashierDto> GetAllCashierService();
        public void UpdateCashierService(CashierUpdateDto cashier, int id);
        public void DeleteCashierService(int id);



    }
}
