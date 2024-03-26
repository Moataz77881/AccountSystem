using AccountSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.DataAccess.Repository.Branches
{
    public class BranchRepo : IBranchesRepository
    {
        private readonly ShaTaskContext context;

        public BranchRepo(ShaTaskContext context) 
        {
            this.context = context;
        }
        public async Task<Branch?> CreateBranchRepo(Branch branch)
        {
            var result = await context.Cities.FirstOrDefaultAsync(x => x.Id == branch.CityId);
            if (result == null) return null;
            await context.Branches.AddAsync(branch);
            await context.SaveChangesAsync();
            return branch;
        }

        public async Task<Branch?> DeleteBranchRepo(int id)
        {
            var result = await context.Branches.FirstOrDefaultAsync(x => x.Id == id);
            if(result == null) return null;
            context.Branches.Remove(result);
            await context.SaveChangesAsync();
            return result;
        }

        public async Task<List<Branch>> GetBranchRepo()
        {
            return await context.Branches.Include(x=>x.City).ToListAsync();
        }

        public async Task<Branch?> UpdateBranchRepo(Branch branch, int id)
        {
            var result = await context.Branches.FirstOrDefaultAsync(x => x.Id == id);
            if(result == null) return null;
            result.BranchName = branch.BranchName;
            await context.SaveChangesAsync();
            return result;

        }
    }
}
