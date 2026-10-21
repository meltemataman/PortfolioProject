using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.ViewComponents.DefaultViewComponents
{
    public class DefaultHeaderComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
