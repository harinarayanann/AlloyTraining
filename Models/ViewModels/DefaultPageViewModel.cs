using AlloyTraining.Models.Pages;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlloyTraining.Models.ViewModels
{
    public class DefaultPageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {
        private T currentPage;

        public DefaultPageViewModel(T currentPage)
        {
            this.currentPage = currentPage;
        }

        public T CurrentPage { get; set; }
        public StartPage StartPage { get; set; }
        public IEnumerable<SitePageData> MenuPages { get; set; }
        public IContent Section { get; set; }
    }
}