using AccountSystem.Model.DTOs.InvoiceDetailDTO;
using AccountSystem.Model.DTOs.InvoiceHeaderDTO;
using Accountystem.Business.Services.InvoiceHeaders;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceHeaderController : ControllerBase
    {
        private readonly IInvoiceHeaderService service;

        public InvoiceHeaderController(IInvoiceHeaderService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IActionResult GetInvoicesHeader() 
        {
            return Ok( service.GetInvoiceHeaderService());
        }
        [HttpPost]
        public IActionResult CreateInvoicesHeader([FromBody] InvoiceHeaderCreationDto invoiceHeader)
        {
            service.CreateInvoiceHeaderService(invoiceHeader);
            return Ok("Invoice Header Created");
        }
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeleteInvoicesHeader([FromRoute] int id)
        {
            service.DeleteInvoiceHeaderService(id);
            return Ok("Invoice Header Deleted");
        }
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult UpdateInvoicesHeader([FromRoute] int id, [FromBody] InvoiceHeaderUpdateDto invoiceheader)
        {
            service.UpdateInvoiceHeaderService(invoiceheader,id);
            return Ok("Invoice Header Updated");
        }
    }
}
