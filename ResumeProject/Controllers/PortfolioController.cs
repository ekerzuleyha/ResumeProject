using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
            var values=_context.Portfolios.Include(x=>x.Category).ToList();
            return View(values);
        }

        public IActionResult CreatePortfolio() 
        {
            //return View();
            List<SelectListItem> values = (from x in _context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }
                                          ).ToList();
            values.Add(new SelectListItem
            {
                Text = "Kategori Seçiniz...",
                Value = "0",
                Selected = true
            });

            ViewBag.v = values;
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

        public IActionResult DeletePortfolio(int id)
        {
            var value = _context.Portfolios.Find(id);
            _context.Portfolios.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {

            List<SelectListItem> values = (from x in _context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }
                                          ).ToList();
            values.Add(new SelectListItem
            {
                Text = "Kategori Seçiniz...",
                Value = "0",
                Selected = true
            });

            ViewBag.v = values;

            var value = _context.Portfolios.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            _context.Portfolios.Update(portfolio);
            _context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
    }
}
