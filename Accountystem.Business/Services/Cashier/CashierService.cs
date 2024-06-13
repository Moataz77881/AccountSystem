using AccountSystem.DataAccess.Repository;
using AccountSystem.Model.DTOs.CashierDTO;
using AccountSystem.Models;
using AutoMapper;

namespace Accountystem.Business.Services.CashierServices
{
    public class CashierService : ICashierService
    {
		private readonly IUnitOfWork unitOfWork;
		private readonly IMapper mapper;

        public CashierService(IUnitOfWork unitOfWork, IMapper mapper)
        {
			this.unitOfWork = unitOfWork;
			this.mapper = mapper;
        }
        public void CreateCashierService(CashierCreationDto cashier)
        {
            unitOfWork.cashier.add(mapper.Map<Cashier>(cashier));
            unitOfWork.complete();
        }

        public void DeleteCashierService(int id)
        {
            var entity = unitOfWork.cashier.getFristOrDefult(x => x.Id == id);
            unitOfWork.cashier.remove(entity);
            unitOfWork.complete();
        }

        public List<CashierDto> GetAllCashierService()
        {
            var result = unitOfWork.cashier.getWithAllDependencies();
            return mapper.Map<List<CashierDto>>(result);
        }

        public void UpdateCashierService(CashierUpdateDto cashier, int id)
        {
            unitOfWork.cashier.UpdateCashierRepo(mapper.Map<Cashier>(cashier), id);
            unitOfWork.complete();
        }
    }
}
