using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "FAQ Item Page", GUID = "f7927024-dd7e-47f0-a290-cf6c64c00993", Description = "")]
    public class FAQItemPage : PageData
    {
        [Display(Name = "Question", Order = 10)]
        public virtual XhtmlString Question { get; set; }
        [Display(Name = "Answer", Order = 20)]
        public virtual XhtmlString Answer { get; set; }
    }
}