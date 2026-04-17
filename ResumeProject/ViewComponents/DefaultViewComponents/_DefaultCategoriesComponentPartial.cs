using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultCategoriesComponentPartial : ViewComponent
    {
        private readonly ResumeDbContext _context;

        public _DefaultCategoriesComponentPartial(ResumeDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values=_context.Categories.ToList();
            return View(values);

        }

      
    }
}
