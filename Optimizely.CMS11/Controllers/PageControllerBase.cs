using System.Web.Mvc;
using EPiServer.Web.Mvc;
using Optimizely.CMS11.Models.Pages;
using Optimizely.CMS11.Models.Pages.ViewModels;

namespace Optimizely.CMS11.Controllers
{
    public class PageControllerBase<TPage> : PageController<TPage>
        where TPage : SitePageData
    {
        protected ActionResult PageView(PageViewModel<TPage> viewModel)
        {
            viewModel.PageTitle = string.IsNullOrEmpty(viewModel.PageTitle)
                ? viewModel.CurrentPage.Name
                : viewModel.CurrentPage.PageTitle;

            return View($"~/Views/Pages/{typeof(TPage).Name}.cshtml", viewModel);
        }

        protected ActionResult PageView(PageViewModel<TPage> viewModel, string route)
        {
            viewModel.PageTitle = string.IsNullOrEmpty(viewModel.PageTitle)
                ? viewModel.CurrentPage.Name
                : viewModel.CurrentPage.PageTitle;

            return View(route, viewModel);
        }
    }
}