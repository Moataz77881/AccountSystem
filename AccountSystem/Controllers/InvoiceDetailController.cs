using AccountSystem.Model.DTOs.InvoiceDetailDTO;
using Accountystem.Business.Services.InvoiceDetails;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceDetailController : ControllerBase
    {
        private readonly IInvoiceDeltailService service;

        public InvoiceDetailController(IInvoiceDeltailService service)
        {
            this.service = service;
        }
      
        [HttpGet]
        public IActionResult GetInvoiceDetail()
        {
            return Ok( service.GetItemsService());
        }
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult UpdateInvoiceDetail([FromRoute] int id, [FromBody] InvoiceUpdateDetailDto invoice)
        {
            service.UpdateItemService(invoice, id);
            return Ok("Invoice Detail Updated");
        }
    }
}
