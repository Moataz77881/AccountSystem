using AccountSystem.DataAccess.Repository;
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
		private readonly IUnitOfWork unitOfWork;
		private readonly IMapper mapper;

        public BranchService(IUnitOfWork unitOfWork, IMapper mapper)
        {
			this.unitOfWork = unitOfWork;
			this.mapper = mapper;
        }
        public void CreateBranchService(CreationBranchDto branch)
        {
            unitOfWork.branch.add(mapper.Map<Branch>(branch));
            unitOfWork.complete();
        }

        public void DeleteBranchService(int id)
        {
            var entity = unitOfWork.branch.getFristOrDefult(filterexpression : x => x.Id == id);
            unitOfWork.branch.remove(entity);
            unitOfWork.complete();
        }

        public List<BranchDto> GetBranchService()
        {
            return mapper.Map<List<BranchDto>>(unitOfWork.branch.getAll(IncludeWord:"City"));
        }

        public void UpdateBranchService(CreationBranchDto branch, int id)
        {
            unitOfWork.branch.UpdateBranchRepo(mapper.Map<Branch>(branch), id);
            unitOfWork.complete();
        }
    }
}
