using System.Web.Optimization;
using GoldenEye.Frontend.Core.Web;

namespace MeetSport.Frontend
{
    public class MvcApplication : WebApplication
    {
        protected override void OnBundleConfig()
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            base.OnBundleConfig();
        }
    }
}
