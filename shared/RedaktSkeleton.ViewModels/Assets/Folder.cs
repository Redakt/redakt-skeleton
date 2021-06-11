using Redakt.BackOffice.Icons;
using Redakt.ContentManagement.Annotations;
using Redakt.ContentManagement.Content;

namespace RedaktSkeleton.ViewModels.Assets
{
    [Folder]
    [Key("__Folder")]
    [AllowAtRoot]
    [AllowChildren(typeof(Folder), typeof(Image), typeof(Document))]
    [Icon(ContentIcons.Folders.Folder)]
    public class Folder: IContentType
    {
    }
}
