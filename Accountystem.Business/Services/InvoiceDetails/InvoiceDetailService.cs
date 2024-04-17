using AccountSystem.DataAccess.Repository.InvoiceDetails;
using AccountSystem.Model.DTOs.InvoiceDetailDTO;
using AccountSystem.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountystem.Business.Services.InvoiceDetails
{
    public class InvoiceDetailService : IInvoiceDeltailService
    {
        private readonly IInvoiceDetailRepo repository;
        private readonly IMapper mapper;

        public InvoiceDetailService(IInvoiceDetailRepo repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<List<InvoiceDetailDto>> GetItemsService()
        {
            return mapper.Map<List<InvoiceDetailDto>>(await repository.GetItemDetailRepo());
        }

        public async Task<InvoiceDetailDto?> UpdateItemService(InvoiceUpdateDetailDto item, int id)
        {
            var result = await repository.UpdateItemDetailRepo(mapper.Map<InvoiceDetail>(item), id);
            if (result == null) return null;
            return mapper.Map<InvoiceDetailDto>(result);
        }
    }
}
