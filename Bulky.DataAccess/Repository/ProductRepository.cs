using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;

namespace Bulky.DataAccess.Repository
{
	public class ProductRepository : Repository<Product>, IProductRepository 
	{
		private ApplicationDbContext _db;
		public ProductRepository(ApplicationDbContext db) : base(db)
		{
			{
				_db = db;
			}
		}
		

		public void update(Product obj)
		{
			//_db.Products.Update(obj);
			var objfromdb = _db.Products.FirstOrDefault(u=>u.Id == obj.Id);
			if (objfromdb != null)
			{
				objfromdb.Title = obj.Title;
				objfromdb.ISBN= obj.ISBN;
				objfromdb.Description = obj.Description ;
				objfromdb.Price50 = obj.Price50;
				objfromdb.Price = obj.Price;
				objfromdb.Price100 = obj.Price100;
				objfromdb.ListPrice = obj.ListPrice;
				objfromdb.CategoryId = obj.CategoryId;
				objfromdb.Author = obj.Author;
				if (obj.ImageUrl != null)
				{
					objfromdb.ImageUrl = obj.ImageUrl;
				}
			}

		}
	}
}
