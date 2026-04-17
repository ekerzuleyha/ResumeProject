using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultServiceComponentPartial:ViewComponent
    {
        private readonly ResumeDbContext _context;

        public _DefaultServiceComponentPartial(ResumeDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke() 
        {
            var values=_context.Services.ToList();
            return View(values);
        }
    }
}
