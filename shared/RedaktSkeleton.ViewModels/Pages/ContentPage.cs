using Redakt.BackOffice.Icons;
using Redakt.ContentManagement.Annotations;
using RedaktSkeleton.ViewModels.Components;
using System.Collections.Generic;

namespace RedaktSkeleton.ViewModels.Pages
{
    [Page]
    [Icon(ContentIcons.Documents.TextFile)]
    [AllowChildren(typeof(ContentPage))]
    [AllowView("ContentPage")]
    [ResponseCache(300)]
    public class ContentPage : PageBase
    {
        [Section("Components")]
        [HelpText("Components will be displayed in vertical order on the page.")]
        [HideLabel]
        public IReadOnlyList<ComponentBase> Components { get; set; }
    }
}
