using System;
using System.ComponentModel.DataAnnotations;
using AlloyTraining.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "News Landing", GUID = "6b0480b1-8a16-4800-87e8-06c1bf594095", Description = "")]
    [SitePageIcon]
    public class NewsLandingPage : SitePageData
    {

        [Display(
            Name = "New Landing",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual ListingBlock NewsListing { get; set; }

        [Display(
            Name = "MainBody",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString MainBody { get; set; }

    }
}