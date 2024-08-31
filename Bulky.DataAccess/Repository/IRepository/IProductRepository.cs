using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Bulky.Models;

namespace Bulky.DataAccess.Repository.IRepository
{
	public interface IProductRepository : IRepository<Product>
	{
		void update(Product obj);
		
		//IEnumerable<Category> GetAll();
		//Category Get(Expression<Func<Category, bool>> filter);
		//void Add(Category entity);
		//void Remove(Category entity);
		//void RemoveRange(IEnumerable<Category> entity);
	}
}
