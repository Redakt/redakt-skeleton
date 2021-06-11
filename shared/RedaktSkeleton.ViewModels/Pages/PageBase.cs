using Redakt.ContentManagement.Annotations;
using Redakt.ContentManagement.Content;

namespace RedaktSkeleton.ViewModels.Pages
{
    public abstract class PageBase: IContentType
    {
        [Section("SEO")]
        [SearchIndex]
        [Tooltip("Main page title displayed in browser window.")]
        [DisplayOrder(100)]
        public string PageTitle { get; set; }

        [Section("SEO")]
        [Multiline]
        [Tooltip("Short page description for SEO display.")]
        [DisplayOrder(100)]
        public string PageDescription { get; set; }
    }
}
