using AccountSystem.DataAccess.Repository;
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
		private readonly IUnitOfWork unitOfWork;
		private readonly IMapper mapper;

        public InvoiceDetailService(IUnitOfWork unitOfWork,IMapper mapper)
        {
			this.unitOfWork = unitOfWork;
			this.mapper = mapper;
        }
        public List<InvoiceDetailDto> GetItemsService()
        {
            return mapper.Map<List<InvoiceDetailDto>>(unitOfWork.invoiceDetail.getAll());
        }

        public void UpdateItemService(InvoiceUpdateDetailDto item, int id)
        {
            unitOfWork.invoiceDetail.UpdateItemDetailRepo(mapper.Map<InvoiceDetail>(item), id);
            unitOfWork.complete();
        }
    }
}
