using System;
using System.Linq;
using AlloyTraining.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace AlloyTraining.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class PreventMoreThanMaxChildrenInitializationModule : IInitializableModule
    {
        private bool initialized = false;
        private IContentEvents events;
        private IContentLoader loader;
        private const int maxChildren = 8;
        public void Initialize(InitializationEngine context)
        {
            //Add initialization logic, this method is called once after CMS has been initialized
            if (!initialized)
            {
                loader = context.Locate.ContentLoader();
                events = context.Locate.ContentEvents();
                events.CreatingContent += Events_CreatingContent;
                initialized = true;
            }
        }

        public void Uninitialize(InitializationEngine context)
        {
            //Add uninitialization logic
            if (initialized)
            {
                events.CreatingContent -= Events_CreatingContent;
            }
        }

        private void Events_CreatingContent(object sender, ContentEventArgs e)
        {
            var sitepage = e.Content as SitePageData;
            if (sitepage != null)
            {
                var children = loader.GetChildren<IContent>(sitepage.ParentLink);
                if (children.Count() >= maxChildren)
                {
                    e.CancelAction = true;
                    e.CancelReason =
                    $"Cannot create a new page if the parent has {maxChildren} or more children.";
                }
            }
        }
    }
}