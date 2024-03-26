using AccountSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.DataAccess.Repository.Branches
{
    public interface IBranchesRepository
    {
        public Task<Branch?> CreateBranchRepo(Branch branch);
        public Task<List<Branch>> GetBranchRepo();
        public Task<Branch?> UpdateBranchRepo(Branch branch,int id);
        public Task<Branch?> DeleteBranchRepo(int id);
    }
}
