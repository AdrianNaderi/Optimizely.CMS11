namespace Optimizely.CMS11.Models.Pages.ViewModels
{
    
    public class PageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {
        public string PageTitle { get; set; }
        public T CurrentPage { get; set; }
        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }
    }
}