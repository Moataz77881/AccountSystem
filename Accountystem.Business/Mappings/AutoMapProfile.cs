using AccountSystem.Model.DTOs.BranchDTO;
using AccountSystem.Model.DTOs.CashierDTO;
using AccountSystem.Model.DTOs.CityDTO;
using AccountSystem.Model.DTOs.InvoiceDetailDTO;
using AccountSystem.Model.DTOs.InvoiceHeaderDTO;
using AccountSystem.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountystem.Business.Mappings
{
    public class AutoMapProfile : Profile
    {
        public AutoMapProfile()
        {
            CreateMap<CashierCreationDto, Cashier>().ReverseMap();
            CreateMap<Cashier, CashierDto>();
            CreateMap<CityCreationDto, City>();
            CreateMap<City, CityDto>();
            CreateMap<CreationBranchDto, Branch>();
            CreateMap<Branch, BranchDto>();
            CreateMap<InvoiceDetailCreationDto, InvoiceDetail>();
            CreateMap<InvoiceDetail, InvoiceDetailDto>();
            CreateMap<InvoiceHeaderCreationDto, InvoiceHeader>();
            CreateMap<InvoiceHeader, InvoiceHeaderDto>();
            CreateMap<InvoiceUpdateDetailDto, InvoiceDetail>();
            CreateMap<CashierUpdateDto, Cashier>();
            CreateMap<InvoiceHeaderUpdateDto, InvoiceHeader>();
        }
    }
}
