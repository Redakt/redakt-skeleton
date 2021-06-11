using Redakt.BackOffice.Icons;
using Redakt.ContentManagement.Annotations;

namespace RedaktSkeleton.ViewModels.Pages
{
    [Page]
    [Icon(ContentIcons.Documents.TextFile)]
    [AllowChildren(typeof(ContentPage))]
    [AllowView("ContentPage")]
    [ResponseCache(300)]
    public class ContentPage : PageBase
    {
    }
}
