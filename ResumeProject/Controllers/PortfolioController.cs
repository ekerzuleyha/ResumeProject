using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;
using ResumeProject.Entities;

namespace ResumeProject.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly ResumeDbContext _context;

        public PortfolioController(ResumeDbContext context)
        {
            _context = context;
        }

        public IActionResult PortfolioList()
        {
            var values=_context.Portfolios.ToList();
            return View(values);
        }

        public IActionResult CreatePortfolio() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio)
        {
            portfolio.ImageUrl = "test";
            _context.Portfolios.Add(portfolio);
            _context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
    }
}
