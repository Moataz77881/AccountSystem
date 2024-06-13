using AccountSystem.DataAccess.Repository;
using AccountSystem.Model.DTOs.InvoiceHeaderDTO;
using AccountSystem.Models;
using AutoMapper;

namespace Accountystem.Business.Services.InvoiceHeaders
{
    public class InvoiceHeaderService : IInvoiceHeaderService
    {
		private readonly IUnitOfWork unitOfWork;
		private readonly IMapper mapper;

        public InvoiceHeaderService(IUnitOfWork unitOfWork,IMapper mapper)
        {
			this.unitOfWork = unitOfWork;
			this.mapper = mapper;
        }

        public void CreateInvoiceHeaderService(InvoiceHeaderCreationDto invoiceHeader)
        {
            unitOfWork.invoiceHeader.add(mapper.Map<InvoiceHeader>(invoiceHeader));
            unitOfWork.complete();
        }

        public void DeleteInvoiceHeaderService(int id)
        {
            unitOfWork.invoiceHeader.DeleteInvoiceRepo(id);
            unitOfWork.complete();
        }

        public List<InvoiceHeaderDto> GetInvoiceHeaderService()
        {
            return mapper.Map<List<InvoiceHeaderDto>>(unitOfWork.invoiceHeader.GetInvoiceRepo());
        }

        public void UpdateInvoiceHeaderService(InvoiceHeaderUpdateDto invoiceHeader, int id)
        {
            unitOfWork.invoiceHeader.UpdateInvoiceRepo(mapper.Map<InvoiceHeader>(invoiceHeader), id);
            unitOfWork.complete();
        }
    }
}
