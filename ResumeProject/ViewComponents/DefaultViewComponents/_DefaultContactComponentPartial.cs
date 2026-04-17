using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultContactComponentPartial:ViewComponent
    {
        private readonly ResumeDbContext _context;

        public _DefaultContactComponentPartial(ResumeDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke() 
        {

            ViewBag.phoneNumber = _context.Contacts.Select(x => x.PhoneNumber).FirstOrDefault();
            ViewBag.eMail = _context.Contacts.Select(x => x.Email).FirstOrDefault();
            ViewBag.address = _context.Contacts.Select(x => x.Address).FirstOrDefault();
            ViewBag.description = _context.Contacts.Select(x=>x.Description).FirstOrDefault();
            return View();
        }
    }
}
