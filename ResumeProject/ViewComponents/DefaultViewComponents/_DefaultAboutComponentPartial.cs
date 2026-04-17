using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultAboutComponentPartial:ViewComponent
    {
        public readonly ResumeDbContext _context;

        public _DefaultAboutComponentPartial(ResumeDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {

            var values = _context.Abouts.ToList();
            return View(values);
        }
    }
}
