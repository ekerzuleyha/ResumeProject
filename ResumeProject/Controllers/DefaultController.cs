using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeProject.Context;
using ResumeProject.Entities;

namespace ResumeProject.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ResumeDbContext _context;

        public DefaultController(ResumeDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public IActionResult SendMessage() 
        //{
        //    return View(); 
        //}

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            message.SendDate = DateTime.Now;
            message.IsRead = false;
            _context.Messages.Add(message);
            _context.SaveChanges();

            //return View("Index");
            TempData["Success"] = "Mesajınız başarıyla gönderildi!";
            return RedirectToAction("Index", "Default");
            // return RedirectToAction("Index", "Default", null, "contact");
            //return View();
        }

    }
}
