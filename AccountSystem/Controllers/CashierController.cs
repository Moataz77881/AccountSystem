using AccountSystem.Model.DTOs.CashierDTO;
using Accountystem.Business.Services.CashierServices;
using Microsoft.AspNetCore.Mvc;

namespace AccountSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CashierController : ControllerBase
    {
        private readonly ICashierService service;

        public CashierController(ICashierService service)
        {
            this.service = service;
        }

        [HttpPost]
        public IActionResult CashierCreation([FromBody] CashierCreationDto cashier) 
        {
            service.CreateCashierService(cashier);
            return Ok("Cashier Added");
        }
        [HttpGet]
        public IActionResult GetAllCashier()
        {
            return Ok( service.GetAllCashierService());
        }
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeleteCashier([FromRoute] int id)
        {
            service.DeleteCashierService(id);
            return Ok("Cashier Deleted");
        }
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult UpdateCashier([FromRoute] int id, [FromBody] CashierUpdateDto cashier)
        {
            service.UpdateCashierService(cashier, id);
            return Ok("Cashier Updated");
        }
    }
}
