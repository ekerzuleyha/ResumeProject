using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.Controllers
{
    public class MessageController : Controller
    {
        private readonly ResumeDbContext _context;

        public MessageController(ResumeDbContext context)
        {
            _context = context;
        }

        public IActionResult MessageList()
        {
            var value=_context.Messages.ToList();
            return View(value);
        }
    }
}
