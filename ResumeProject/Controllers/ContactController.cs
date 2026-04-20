using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;
using ResumeProject.Entities;
using ResumeProject.ViewComponents.DefaultViewComponents;

namespace ResumeProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly ResumeDbContext _context;

        public ContactController(ResumeDbContext context)
        {
            _context = context;
        }

        public IActionResult ContactList()
        {
            var values=_context.Contacts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateContact() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateContact(Contact contact) 
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return RedirectToAction("ContactList");
        }

        public IActionResult DeleteContact(int id)
        {
            var value = _context.Contacts.Find(id);
            _context.Contacts.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("ContactList");
        }

        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var value = _context.Contacts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            _context.Contacts.Update(contact);
            _context.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}
