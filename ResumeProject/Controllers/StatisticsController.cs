using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly ResumeDbContext _context;

        public StatisticsController(ResumeDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.v1 = _context.Messages.Count();
            ViewBag.v2= _context.Messages.Where(x=>x.IsRead==false).Count();
            ViewBag.v3= _context.Messages.Where(x=>x.IsRead==true).Count();
            ViewBag.v4= _context.Messages.Where(x=>x.MessageId==1).Select(y=>y.NameSurname).FirstOrDefault();
            return View();
        }
    }
}
