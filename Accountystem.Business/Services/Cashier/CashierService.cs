using AccountSystem.DataAccess.Repository.Cashiers;
using AccountSystem.Model.DTOs.CashierDTO;
using AccountSystem.Models;
using AutoMapper;

namespace Accountystem.Business.Services.CashierServices
{
    public class CashierService : ICashierService
    {
        private readonly ICashierRepository repository;
        private readonly IMapper mapper;

        public CashierService(ICashierRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<CashierDto?> CreateCashierService(CashierCreationDto cashier)
        {
            var result = await repository.CreateCashierRepo(mapper.Map<Cashier>(cashier));
            if (result == null) return null;
            return mapper.Map<CashierDto>(result);
        }

        public async Task<CashierDto?> DeleteCashierService(int id)
        {
            var result = await repository.DeleteCashierRepo(id);
            if (result == null) return null;
            return mapper.Map<CashierDto>(result);
        }

        public async Task<List<CashierDto>> GetAllCashierService()
        {
            var result = await repository.GetAllCashierRepo();
            return mapper.Map<List<CashierDto>>(result);
        }

        public async Task<CashierDto?> UpdateCashierService(CashierUpdateDto cashier, int id)
        {
            var result = await repository.UpdateCashierRepo(mapper.Map<Cashier>(cashier), id);
            if (result == null) return null;
            return mapper.Map<CashierDto>(result);
        }
    }
}
