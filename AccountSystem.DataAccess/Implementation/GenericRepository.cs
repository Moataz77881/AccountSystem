using AccountSystem.DataAccess.Repository;
using AccountSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace AccountSystem.DataAccess.Implementation
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		private readonly ShaTaskContext context;
		private readonly DbSet<T> dbSet;
		public GenericRepository(ShaTaskContext context)
        {
			this.context = context;
			dbSet = context.Set<T>();
		}
        public void add(T Entity)
		{
			dbSet.Add(Entity);
		}

		public void AddRange(T Entity)
		{
			dbSet.AddRange(Entity);
		}

		public List<T> getAll(string? includeWord = null , Expression<Func<T, bool>>? filterExpression = null)
		{
			IQueryable<T> query = dbSet;
			if (filterExpression != null) 
			{
				query = query.Where(filterExpression);
			}
			if (includeWord != null) 
			{
				//(branch,city)
				foreach (var w in includeWord.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)) 
				{
					query = query.Include(w);
				}
			}
			

			return query.ToList();
		}

		public T getFristOrDefult(Expression<Func<T, bool>>? filterExpression = null, string? IncludeWords = null)
		{
			IQueryable<T> query = dbSet;
			if (filterExpression != null) 
			{
				query = query.Where(filterExpression);
			}
			if (IncludeWords != null) 
			{
				foreach (var w in IncludeWords.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)) 
				{
					query = query.Include(w);
				}
			}
			return query.FirstOrDefault();
		}

		public void remove(T Entity)
		{
			dbSet.Remove(Entity);
		}

		public void RemoveRange(ICollection<T> Entity)
		{
			dbSet.RemoveRange(Entity);
		}
	}
}
