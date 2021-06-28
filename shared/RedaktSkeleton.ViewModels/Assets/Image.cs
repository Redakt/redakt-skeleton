using Redakt.BackOffice.Icons;
using Redakt.ContentManagement.Annotations;
using Redakt.ContentManagement.Content;

namespace RedaktSkeleton.ViewModels.Assets
{
    [Asset]
    [Key("__Image")]
    [Icon(ContentIcons.Image)]
    [MediaUpload]
    public class Image: IContentType
    {
        [AcceptMediaType("image/jpeg", "image/gif", "image/png", "image/bmp", "image/tiff", "image/svg+xml")]
        [Section("Image")]
        public Media File { get; set; }

        [Section("Image")]
        [CultureDependent]
        public string AlternateText { get; set; }
    }
}
