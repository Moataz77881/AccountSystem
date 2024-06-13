using AccountSystem.Model.DTOs.BranchDTO;

namespace Accountystem.Business.Services.Branchs
{
    public interface IBrachService
    {
        public void CreateBranchService(CreationBranchDto branch);
        public List<BranchDto> GetBranchService();
        public void DeleteBranchService(int id);
        public void UpdateBranchService(CreationBranchDto branch, int id);
    }
}
