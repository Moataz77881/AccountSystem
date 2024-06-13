using AccountSystem.DataAccess.Repository;
using AccountSystem.DataAccess.Repository.InvoiceDetails;
using AccountSystem.DataAccess.Repository.InvoiceHeaders;
using AccountSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.DataAccess.Implementation
{
    public class UnitOfwork : IUnitOfWork
	{
		private readonly ShaTaskContext context;
		public ICityRepository city { get; private set; }

		public ICashierRepository cashier { get; private set; }

		public IBranchesRepository branch { get; private set; }
		public IInvoiceHeaderRepository invoiceHeader { get ; private set ; }
		public IInvoiceDetailRepo invoiceDetail { get; private set; }


		public UnitOfwork(ShaTaskContext context, ICityRepository cityRepository,
			ICashierRepository cashierRepository, IBranchesRepository branchesRepository,
			IInvoiceHeaderRepository invoiceHeaderRepository, IInvoiceDetailRepo invoiceDetailRepository)
        {
			this.context = context;
			city = cityRepository;
			cashier = cashierRepository;
			branch = branchesRepository;
			invoiceHeader = invoiceHeaderRepository;
			invoiceDetail = invoiceDetailRepository;
		}
        public int complete()
		{
			return context.SaveChanges();
		}

		public void Dispose()
		{
			context.Dispose();
		}
	}
}
