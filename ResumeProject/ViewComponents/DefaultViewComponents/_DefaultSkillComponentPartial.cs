using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultSkillComponentPartial:ViewComponent
    {
        private readonly ResumeDbContext _context;

        public _DefaultSkillComponentPartial(ResumeDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values=_context.Skills.ToList();
            return View(values);
        }
    }
}
