using Redakt.ContentManagement.Annotations;
using Redakt.ContentManagement.Content;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RedaktSkeleton.ViewModels.Components
{
    [TitleFormat("[Features]")]
    public class Features: ComponentBase
    {
        public IReadOnlyList<Feature> Items { get; set; }
    }

    [TitleFormat("[Feature] {{Title}}")]
    public class Feature: IContentType
    {
        [SelectList("house", "alarm", "arrow-repeat|arrows", "award", "bag-check|bag", "bar-chart|bar chart", "calendar-date|calendar", "cpu-fill|CPU", "gear-fill|gear", "speedometer", "tools", "geo-fill|location", "globe", "shield-check|shield")]
        public string Icon { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public Link CallToAction { get; set; }
    }
}
