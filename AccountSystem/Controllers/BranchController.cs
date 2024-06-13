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
        public IActionResult CreateBranch([FromBody] CreationBranchDto branch)
        {
            service.CreateBranchService(branch);
            return Ok("Branch Added");
        }
        [HttpGet]
        public IActionResult GetBranches()
        {
            return Ok(service.GetBranchService());
        }
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult UpdateBranch([FromRoute] int id, [FromBody] CreationBranchDto branch)
        {
             service.UpdateBranchService(branch, id);
            return Ok("Branch Updated");
        }
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeleteBranch([FromRoute] int id)
        {
            service.DeleteBranchService(id);
            return Ok("Branch Deleted");
        }
    }
}
