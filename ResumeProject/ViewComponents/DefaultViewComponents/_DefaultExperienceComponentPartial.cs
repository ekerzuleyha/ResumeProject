using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultExperienceComponentPartial:ViewComponent
    {
        
        private readonly ResumeDbContext _context;

        public _DefaultExperienceComponentPartial(ResumeDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke() 
        {
            
            var values = _context.Experiences.ToList();
            return View(values);
        }
    }
}
