using AlloyTraining.Models.Pages;
using AlloyTraining.Models.ViewModels;
using EPiServer;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using System.Web.Mvc;

namespace AlloyTraining.Controllers
{
    [TemplateDescriptor(Inherited = true, Tags = new[] { SiteTags.Full }, AvailableWithoutTag = true)]
    public class AllPagesPartialController : PartialContentController<SitePageData>
    {
        public override ActionResult Index(SitePageData currentPage)
        {
            return PartialView(viewName: SiteTags.Full, model: PageViewModel.Create(currentPage));
        }
    }
}