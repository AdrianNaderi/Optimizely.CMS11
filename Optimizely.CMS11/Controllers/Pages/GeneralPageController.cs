using System.Web.Mvc;
using Optimizely.CMS11.Models.Pages;
using Optimizely.CMS11.Models.Pages.ViewModels;

namespace Optimizely.CMS11.Controllers.Pages
{
    public class GeneralPageController : PageControllerBase<GeneralPage>
    {
        public ActionResult Index(GeneralPage currentPage)
        {
            return PageView(new GeneralPageViewModel(currentPage));
        }
    }
}