using Redakt.BackOffice.Icons;
using Redakt.ContentManagement.Annotations;
using Redakt.ContentManagement.Content;

namespace RedaktSkeleton.ViewModels.Assets
{
    [Asset]
    [Key("__Document")]
    [Icon(ContentIcons.Document)]
    [FileUpload]
    public class Document: IContentType
    {
        public Media File { get; set; }

        public string Title { get; set; }
    }
}
