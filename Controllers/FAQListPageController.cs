using AlloyTraining.Models.Pages;
using AlloyTraining.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlloyTraining.Controllers
{
    public class FAQListPageController : PageControllerBase<FAQListPage>
    {
        //private readonly IContentLoader _loader;
        // GET: FAQListPage
        public FAQListPageController(IContentLoader loader, IContentRepository repository) : base (loader, repository)
        {
            //this._loader = loader;
        }
        public ActionResult Index(FAQListPage currentPage)
        {
            var viewModel = CreatePageViewModel(currentPage);
            var faqs = loader.GetChildren<FAQItemPage>(currentPage.ContentLink);
            viewModel.CurrentPage.FAQItems = faqs;
            return View(viewModel);
        }
        public ActionResult CreateFAQItem(FAQListPage currentPage, string question)
        {
            var faqItem = repository.GetDefault<FAQItemPage>(currentPage.ContentLink);
            // if someone is logged in then CreatedBy and ChangedBy will be set,
            // otherwise they will be empty string which is shown as "installer"
            if (string.IsNullOrEmpty(faqItem.CreatedBy))
                faqItem.CreatedBy = "Anonymous";
            if (string.IsNullOrEmpty(faqItem.ChangedBy))
                faqItem.ChangedBy = "Anonymous";
            faqItem.Question = new XhtmlString(question);
            faqItem.Name = "Q. " + question;
            repository.Save(faqItem, EPiServer.DataAccess.SaveAction.CheckOut,
                        EPiServer.Security.AccessLevel.Read);
            return RedirectToAction("Index");
        }
    }
}