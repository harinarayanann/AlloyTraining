using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlloyTraining.Models.ViewModels
{
    public class ContentFolderViewModel
    {
        public ContentFolder CurrentFolder { get; set; }
        public int ItemsCount { get; set; }
    }
}