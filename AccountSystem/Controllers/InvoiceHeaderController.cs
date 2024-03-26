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
        public async Task<IActionResult> GetInvoicesHeader() 
        {
            return Ok(await service.GetInvoiceHeaderService());
        }
        [HttpPost]
        public async Task<IActionResult> CreateInvoicesHeader([FromBody] InvoiceHeaderCreationDto invoiceHeader)
        {
            var result = await service.CreateInvoiceHeaderService(invoiceHeader);
            if (result == null) return NotFound();
            return Ok("Invoice Header Created");
        }
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteInvoicesHeader([FromRoute] int id)
        {
            var result = await service.DeleteInvoiceHeaderService(id);
            if (result == null) return NotFound();
            return Ok("Invoice Header Deleted");
        }
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateInvoicesHeader([FromRoute] int id, [FromBody] InvoiceHeaderUpdateDto invoiceheader)
        {
            var result = await service.UpdateInvoiceHeaderService(invoiceheader,id);
            if (result == null) return NotFound();
            return Ok("Invoice Header Updated");
        }
    }
}
