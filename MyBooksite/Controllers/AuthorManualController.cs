using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBooksite.Data;
using MyBooksite.Models;

namespace MyBooksite.Controllers
{
    public class AuthorManualController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        // constructor injection
        public AuthorManualController(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }
        public IActionResult Detailsnew()
        {
            List<Author> _authorlist = _dbContext.Author.ToList();
            return View(_authorlist);
        }
    }
}

