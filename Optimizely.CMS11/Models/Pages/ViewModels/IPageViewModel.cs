namespace Optimizely.CMS11.Models.Pages.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageData
    {
        string PageTitle { get; set; }
        T CurrentPage { get; }
    }
}