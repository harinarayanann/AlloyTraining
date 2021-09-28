using System.Web;
using EPiServer.Framework.Web;
using EPiServer.Web;

namespace AlloyTraining.Business.DisplayChannels
{
    public class MobileDisplayChannel : DisplayChannel
    {
        public override string ChannelName => RenderingTags.Mobile;
        public override string ResolutionId => "iphone5";

        public override bool IsActive(HttpContextBase context)
        {
            return context.Request.Browser.IsMobileDevice;
        }
    }

    public class iPhone5 : IDisplayResolution
    {
        string IDisplayResolution.Id => "iphone5";

        string IDisplayResolution.Name => "iPhone 5 (320 x 568)";

        int IDisplayResolution.Width => 320;

        int IDisplayResolution.Height => 568;
    }

    public class iPhone4 : IDisplayResolution
    {
        string IDisplayResolution.Id => "iphone4";

        string IDisplayResolution.Name => "iPhone 4 (320 x 480)";

        int IDisplayResolution.Width => 320;

        int IDisplayResolution.Height => 480;
    }
}