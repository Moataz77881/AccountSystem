using AccountSystem.DataAccess.Repository;
using AccountSystem.Models;


namespace AccountSystem.DataAccess.Implementation
{
    public class BranchRepo : GenericRepository<Branch>, IBranchesRepository
    {
        private readonly ShaTaskContext context;

        public BranchRepo(ShaTaskContext context) : base(context)
        {
            this.context = context;
        }

        public void UpdateBranchRepo(Branch branch, int id)
        {
            var result = context.Branches.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                result.BranchName = branch.BranchName;
            }

        }
	}
}
