using System.Web;
using System.Web.Optimization;

namespace MrCasting.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/MrCastingApp")
                //.Include("~/Scripts/angular/angular.min.js")
                //.Include("~/Scripts/angular/angular-route.min.js")
                .IncludeDirectory("~/Scripts/Controllers", "*.js")
                .IncludeDirectory("~/Scripts/Factories", "*.js")
                .Include("~/Scripts/MrCastingApp.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));

            BundleTable.EnableOptimizations = false;
        }
    }
}
