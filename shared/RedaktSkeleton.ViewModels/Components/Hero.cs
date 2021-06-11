using Redakt.ContentManagement.Annotations;
using Redakt.ContentManagement.Content;
using System.ComponentModel.DataAnnotations;

namespace RedaktSkeleton.ViewModels.Components
{
    [TitleFormat("[Hero] {{Title}}")]
    public class Hero: ComponentBase
    {
        [Required]
        public string Title { get; set; }

        [Multiline]
        public string LeadText { get; set; }

        public Link PrimaryCallToAction { get; set; }

        public Link SecondaryCallToAction { get; set; }
    }
}
