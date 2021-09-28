using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "FAQ List Page", 
        GUID = "52ab3b07-1502-4844-a677-c6af5b723a4c", 
        Description = "")]
    [SiteImageUrl]
    [AvailableContentTypes(Availability =Availability.Specific, Include = new[] { typeof(FAQItemPage)}, 
        IncludeOn = new[] { typeof(StartPage)})]
    public class FAQListPage : SitePageData
    {
        // having an ignored property avoids needing a view model
        // this property will not be stored in CMS so it does not
        // need to be virtual
        [Ignore]
        public IEnumerable<FAQItemPage> FAQItems { get; set; }
    }
}