using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using AlloyTraining.Models.Media;
using EPiServer.Shell.ObjectEditing;
using AlloyTraining.Business.SelectionFactories;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Start",
        // your code will have a random GUID here
        GroupName = SiteGroupNames.Specialized, Order = 10,
        Description = "The home page for a website with an area for blocks and partial pages.")]
    [AvailableContentTypes(Include = new[] { typeof(StandardPage) })]
    [SiteStartIcon]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(Name = "Heading",
            Description = "If the Heading is not set, the page falls back to showing the Name.",
            GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(Name = "Main body",
            Description = "The main body uses the XHTML-editor you can insert for example text, images, and tables.",
            GroupName = SystemTabNames.Content, Order = 20)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(Name = "Main content area",
            Description = "The main content area contains an ordered collection to content references, for example blocks, media assets, and pages.",
            GroupName = SystemTabNames.Content, Order = 30)]
        [AllowedTypes(typeof(StandardPage), typeof(BlockData), typeof(ImageData), typeof(ContentFolder), typeof(PdfFile))]
        public virtual ContentArea MainContentArea { get; set; }

        [CultureSpecific]
        [Display(Name = "Footer text",
        Description = "The footer text will be shown at the bottom of every page.",
        GroupName = CMSTabs.SiteSettings, Order = 10)]
        public virtual string FooterText { get; set; }

        //[Display(Name = "AutoSuggest",
        //Description = "The footer text will be shown at the bottom of every page.",
        //GroupName = SystemTabNames.Content, Order = 40)]
        //[UIHint("AutoSuggest")]
        //public virtual string AutoSuggest { get; set; }

        [AutoSuggestSelection(typeof(MySelectionQuery))]
        public virtual string SelectionEditor1 { get; set; }

        [AutoSuggestSelection(typeof(MySelectionQuery), AllowCustomValues = true)]
        public virtual string SelectionEditor2 { get; set; }

        [Display(Name = "Search page",
        Description = "If you add a Search page to the site, set this property to reference it to enable search from every page.",
        GroupName = CMSTabs.SiteSettings,
        Order = 40)]
        [AllowedTypes(typeof(SearchPage))]
        public virtual PageReference SearchPageLink { get; set; }
    }
}