using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Optimizely.CMS11.Models.Pages
{
    [ContentType(
        GUID = "18F39152-BEA5-4658-8299-9AA2B0126C16",
        DisplayName = "Page: General",
        Description = "This is an general page"
    )]
    public class GeneralPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual ContentArea MainBody { get; set; }
    }
}