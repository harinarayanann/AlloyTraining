using AlloyTraining.Models.Pages;
using AlloyTraining.Models.ViewModels;
using EPiServer;
using EPiServer.Web.Mvc;
using System.Web.Mvc;

namespace AlloyTraining.Controllers
{
    public class NewsLandingPageController : PageControllerBase<NewsLandingPage>
    {
        //public ActionResult Index(SitePageData currentPage)
        //{
        //    var viewmodel = new PageViewModel<SitePageData>(currentPage);

        //    return View(viewmodel);
        //}

        public NewsLandingPageController(IContentLoader loader) : base(loader)
        {
        }

        public ActionResult Index(NewsLandingPage currentPage)
        {
            return View(CreatePageViewModel(currentPage));
        }
    }
}