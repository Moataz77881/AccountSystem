using AccountSystem.DataAccess.Repository.InvoiceDetails;
using AccountSystem.DataAccess.Repository.InvoiceHeaders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.DataAccess.Repository
{
    public interface IUnitOfWork : IDisposable
	{
		public ICityRepository city { get;}
        public ICashierRepository cashier { get;}
        public IBranchesRepository branch { get;}
        public IInvoiceHeaderRepository invoiceHeader { get; }
		public IInvoiceDetailRepo invoiceDetail { get; }

		int complete();
	}
}
