using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.Controllers
{
    public class AdminLayoutController : Controller
    {
        private readonly ResumeDbContext _context;

        public AdminLayoutController(ResumeDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
