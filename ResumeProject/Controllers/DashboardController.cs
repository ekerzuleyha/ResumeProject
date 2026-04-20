using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ResumeDbContext _context;

        public DashboardController(ResumeDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //var model = new
            //{
            //    ProjectCount = _context.Portfolios.Count(),
            //    MessageCount = _context.Messages.Count(),
            //    UnreadMessageCount = _context.Messages.Count(x => !x.IsRead),
            //    SkillCount = _context.Skills.Count(),

            //    LastMessages = _context.Messages
            //.OrderByDescending(x => x.SendDate)
            //.Take(5)
            //.ToList(),

            //    LastProjects = _context.Portfolios
            //.OrderByDescending(x => x.PortfolioId)
            //.Take(6)
            //.ToList(),

            //    ChartLabels = _context.Portfolios
            //.GroupBy(x => x.Category)
            //.Select(x => x.Key)
            //.ToList(),

            //    ChartData = _context.Portfolios
            //.GroupBy(x => x.Category)
            //.Select(x => x.Count())
            //.ToList()
            //};

            //return View(model);
            return View();
        }
    }
}
