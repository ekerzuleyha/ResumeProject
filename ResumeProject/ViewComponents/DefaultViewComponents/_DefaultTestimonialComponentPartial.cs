using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultTestimonialComponentPartial:ViewComponent
    {
        private readonly ResumeDbContext _context;

        public _DefaultTestimonialComponentPartial(ResumeDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke() 
        {
            var values=_context.Testimonials.ToList();
            return View(values);
        }
    }
}
