using AccountSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.DataAccess.Repository
{
    public interface IBranchesRepository : IGenericRepository<Branch>
    {
        public void UpdateBranchRepo(Branch branch, int id);
    }
}
