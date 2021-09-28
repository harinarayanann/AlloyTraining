using AlloyTraining.Models.Pages;
using EPiServer;
using System.Web.Mvc;
using EPiServer.Framework.Web;
using EPiServer.Framework.DataAnnotations;

namespace AlloyTraining.Controllers
{
    [TemplateDescriptor(Tags = new[] { RenderingTags.Mobile }, AvailableWithoutTag = false)]
    public class StartPageMobileController : PageControllerBase<StartPage>
    {
        public StartPageMobileController(IContentLoader loader) : base(loader)
        {
        }

        public ActionResult Index(StartPage currentPage)
        {
            return View(CreatePageViewModel(currentPage));
        }
    }
}