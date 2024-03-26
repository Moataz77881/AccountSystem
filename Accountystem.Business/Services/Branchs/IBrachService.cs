using AccountSystem.Model.DTOs.BranchDTO;

namespace Accountystem.Business.Services.Branchs
{
    public interface IBrachService
    {
        public Task<BranchDto?> CreateBranchService(CreationBranchDto branch);
        public Task<List<BranchDto>> GetBranchService();
        public Task<BranchDto?> DeleteBranchService(int id);
        public Task<BranchDto?> UpdateBranchService(CreationBranchDto branch, int id);

    }
}
