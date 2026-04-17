using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultMesssageComponentPartial:ViewComponent
    {

        public IViewComponentResult Invoke() 
        {
            return View();

        }

      
    }
}
