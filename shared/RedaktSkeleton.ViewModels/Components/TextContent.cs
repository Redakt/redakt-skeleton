using Microsoft.AspNetCore.Html;
using Redakt.ContentManagement.Annotations;
using System.ComponentModel.DataAnnotations;

namespace RedaktSkeleton.ViewModels.Components
{
    [TitleFormat("[Text]")]
    public class TextContent: ComponentBase
    {
        [Required]
        public HtmlString Text { get; set; }
    }
}
