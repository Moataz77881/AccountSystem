using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.DataAccess.Repository
{
	public interface IGenericRepository<T> where T : class
	{
		public List<T> getAll(string? IncludeWord = null, Expression<Func<T,bool>>? filterexpression = null);
		public void add(T Entity);
		public void remove(T Entity);
		public T getFristOrDefult(Expression<Func<T, bool>>? filterexpression = null, string? IncludeWords = null);
		public void AddRange(T Entity);
		public void RemoveRange(ICollection<T> Entity);
	}
}
