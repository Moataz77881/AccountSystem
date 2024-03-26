using AccountSystem.DataAccess.Repository.InvoiceHeaders;
using AccountSystem.Model.DTOs.InvoiceHeaderDTO;
using AccountSystem.Models;
using Accountystem.Business.Services.InvoiceHeaders;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountystem.Business.Services.InvoiceHeaders
{
    public class InvoiceHeaderService : IInvoiceHeaderService
    {
        private readonly IInvoiceHeaderRepository repository;
        private readonly IMapper mapper;

        public InvoiceHeaderService(IInvoiceHeaderRepository repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<InvoiceHeaderDto> CreateInvoiceHeaderService(InvoiceHeaderCreationDto invoiceHeader)
        {
            var result = await repository.CreateInvoiceRepo(mapper.Map<InvoiceHeader>(invoiceHeader));
            return mapper.Map<InvoiceHeaderDto>(result);
        }

        public async Task<InvoiceHeaderDto?> DeleteInvoiceHeaderService(int id)
        {
            var result = await repository.DeleteInvoiceRepo(id);
            if (result == null) return null;
            return mapper.Map<InvoiceHeaderDto>(result);
        }

        public async Task<List<InvoiceHeaderDto>> GetInvoiceHeaderService()
        {
            return mapper.Map<List<InvoiceHeaderDto>>(await repository.GetInvoiceRepo());
        }

        public async Task<InvoiceHeaderDto?> UpdateInvoiceHeaderService(InvoiceHeaderUpdateDto invoiceHeader, int id)
        {
            var result = await repository.UpdateInvoiceRepo(mapper.Map<InvoiceHeader>(invoiceHeader), id);
            if (result == null) return null;
            return mapper.Map<InvoiceHeaderDto>(result);
        }
    }
}
