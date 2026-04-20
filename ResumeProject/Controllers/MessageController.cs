using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;
using ResumeProject.Entities;

namespace ResumeProject.Controllers
{
    public class MessageController : Controller
    {
        private readonly ResumeDbContext _context;

        public MessageController(ResumeDbContext context)
        {
            _context = context;
        }

        public IActionResult MessageList(int? id)
        {

            // Eğer id geliyorsa, o mesajı okundu yap
            if (id.HasValue)
            {
                var message = _context.Messages.Find(id.Value);
                if (message != null && !message.IsRead)
                {
                    message.IsRead = true;
                
                    _context.SaveChanges();
                }
            }
            var value=_context.Messages.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult CreateMessage() 
        {
            return View();        
        }

        [HttpPost]
        public IActionResult CreateMessage(Message message)
        {
            _context.Messages.Add(message);
            message.IsRead = false;
            message.SendDate= DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("MessageList");
        }

        


        public IActionResult DeleteMessage(int id) 
        {
            var value = _context.Messages.Find(id);
            _context.Messages.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("MessageList");
        }

        [HttpGet]
        public IActionResult UpdateMessage(int id)
        {
            var value=_context.Messages.Find(id);
            return View(value);
            
        }

        [HttpPost]
        public IActionResult UpdateMessage(Message message)
        {
            _context.Messages.Update(message);
            _context.SaveChanges();
            return RedirectToAction("MessageList");
        }

    }
}
