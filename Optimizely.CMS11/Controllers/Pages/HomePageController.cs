using System.Web.Mvc;
using Optimizely.CMS11.Models.Pages;
using Optimizely.CMS11.Models.Pages.ViewModels;

namespace Optimizely.CMS11.Controllers.Pages
{
    public class HomePageController : PageControllerBase<HomePage>
    {
        public ActionResult Index(HomePage currentPage)
        {
            return PageView(new HomePageViewModel(currentPage));
        }
    }
}