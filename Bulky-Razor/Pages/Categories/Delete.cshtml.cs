using Azure;
using Bulky_Razor.Data;
using Bulky_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bulky_Razor.Pages.Categories
{
	[BindProperties]
    public class DeleteModel : PageModel
    {
		private readonly ApplicationDbContext _db;
		[BindProperty]
		public Category Category { get; set; }

		public DeleteModel(ApplicationDbContext db)
		{
			_db = db;
		}

		public void OnGet(int? id)
		{
			if (id != null && id != 0)
			{
				Category = _db.Categories.Find(id);
			}
		}
		//	if (id == null || id == 0)
		//	{
		//		return NotFound();
		//	}
		//	Category? categoryfromDb = _db.Categories.Find(id); //only for primary key
		//														//Category? categoryfromDb1 = _db.Categories.FirstOrDefault(u=>u.Id==id);
		//														//Category? categoryfromDb2 = _db.Categories.Where(u=>u.Id==id).FirstOrDefault();
		//	if (categoryfromDb == null)
		//	{
		//		return NotFound();
		//	}
		//	return Page(categoryfromDb);
		//}

		public IActionResult OnPost()
		{
			Category? obj = _db.Categories.Find(Category.Id);
			if (obj == null)
			{
				return NotFound();
			}
			_db.Categories.Remove(obj);
			_db.SaveChanges();
			//TempData["success"] = "Category Removed successfully";
			return RedirectToPage("Index");
		}

	}
}
