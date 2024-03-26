using AccountSystem.Model.DTOs.BranchDTO;
using Accountystem.Business.Services.Branchs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBrachService service;

        public BranchController(IBrachService service)
        {
            this.service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBranch([FromBody] CreationBranchDto branch)
        {
            var result = await service.CreateBranchService(branch);
            if (result == null) return NotFound();
            return Ok("Branch Added");
        }
        [HttpGet]
        public async Task<IActionResult> GetBranches()
        {
            return Ok(await service.GetBranchService());
        }
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateBranch([FromRoute] int id, [FromBody] CreationBranchDto branch)
        {
            var result = await service.UpdateBranchService(branch, id);
            if (result == null) return NotFound();
            return Ok("Branch Updated");
        }
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteBranch([FromRoute] int id)
        {
            var result = await service.DeleteBranchService(id);
            if (result == null) return NotFound();
            return Ok("Branch Deleted");
        }

    }
}
