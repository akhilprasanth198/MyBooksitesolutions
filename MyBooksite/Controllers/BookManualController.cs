using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBooksite.Data;
using MyBooksite.Models;

namespace MyBooksite.Controllers
{
	public class BookManualController : Controller
	{
		private readonly ApplicationDBContext _dbContext;
		// constructor injection
		public BookManualController(ApplicationDBContext applicationDBContext)
		{
			_dbContext = applicationDBContext;
		}
		public IActionResult details()
		{
			List<Book> _booklist = _dbContext.Book.ToList();
			return View(_booklist);
		}
        public IActionResult listbook()
		{
            List<Book> _booklist = _dbContext.Book.Include(x=>x.Authorentry).ToList();
			return View(_booklist);
		}
	}
}
