﻿using AccountSystem.Model.DTOs.InvoiceDetailDTO;
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
        public async Task<IActionResult> GetInvoiceDetail()
        {
            return Ok(await service.GetItemsService());
        }
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateInvoiceDetail([FromRoute] int id, [FromBody] InvoiceUpdateDetailDto invoice)
        {
            var result = await service.UpdateItemService(invoice, id);
            if (result == null) return NotFound();
            return Ok("Invoice Detail Updated");
        }
    }
}
