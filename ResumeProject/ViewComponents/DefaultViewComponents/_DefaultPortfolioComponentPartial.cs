using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultPortfolioComponentPartial:ViewComponent
    {
        private readonly ResumeDbContext _context;

        public _DefaultPortfolioComponentPartial(ResumeDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke() 
        {
            var values=_context.Portfolios.ToList();
            return View(values);
        }
    }
}
