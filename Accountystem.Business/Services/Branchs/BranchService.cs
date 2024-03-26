using AccountSystem.DataAccess.Repository.Branches;
using AccountSystem.Model.DTOs.BranchDTO;
using AccountSystem.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountystem.Business.Services.Branchs
{
    public class BranchService : IBrachService
    {
        private readonly IBranchesRepository repository;
        private readonly IMapper mapper;

        public BranchService(IBranchesRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<BranchDto?> CreateBranchService(CreationBranchDto branch)
        {
            var result = await repository.CreateBranchRepo(mapper.Map<Branch>(branch));
            if(result==null) return null;
            return mapper.Map<BranchDto>(result);
        }

        public async Task<BranchDto?> DeleteBranchService(int id)
        {
            var result = await repository.DeleteBranchRepo(id);
            if (result == null) return null;
            return mapper.Map<BranchDto>(result);
        }

        public async Task<List<BranchDto>> GetBranchService()
        {
            return mapper.Map<List<BranchDto>>(await repository.GetBranchRepo());
        }

        public async Task<BranchDto?> UpdateBranchService(CreationBranchDto branch, int id)
        {
            var result = await repository.UpdateBranchRepo(mapper.Map<Branch>(branch), id);
            if (result == null) return null;
            return mapper.Map<BranchDto>(result);

        }
    }
}
