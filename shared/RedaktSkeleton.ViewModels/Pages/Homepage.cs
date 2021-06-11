using Redakt.BackOffice.Icons;
using Redakt.ContentManagement.Annotations;

namespace RedaktSkeleton.ViewModels.Pages
{
    [Page]
    [Icon(ContentIcons.Web.Home)]
    [AllowAtRoot]
    [AllowChildren(typeof(ContentPage))]
    [AllowView("Homepage")]
    [ResponseCache(300)]
    public class Homepage: PageBase
    {
    }
}
