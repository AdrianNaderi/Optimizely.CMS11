using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace Optimizely.CMS11.Models.Pages
{
    public abstract class SitePageData : PageData
    {   
        [Display(
            Name = "Make Page Searchable",
            GroupName = SystemTabNames.Settings,
            Order = 10)]
        public virtual bool IsSearchable { get; set; }

        [Display(
            Name = "Page Title",
            GroupName = "SEO",
            Order = 10)]
        [CultureSpecific]
        public virtual string PageTitle { get; set; }

        [Display(
            Name = "Meta Description",
            GroupName = "SEO",
            Order = 20)]
        [CultureSpecific]
        // ReSharper disable once Mvc.TemplateNotResolved
        [UIHint(UIHint.Textarea)]
        public virtual string MetaDescription { get; set; }

        [Display(
            GroupName = "SEO",
            Order = 30)]
        [CultureSpecific]
        [BackingType(typeof(PropertyStringList))]
        public virtual string[] MetaKeywords { get; set; }
    }
}