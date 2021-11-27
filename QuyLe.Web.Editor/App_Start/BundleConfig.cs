using System.Web.Optimization;

namespace QuyLe.Web.Editor
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // Admira templates
            bundles.Add(new StyleBundle("~/Admiria/css").Include(
                "~/Admiria/assets/css/bootstrap.min.css",
                "~/Admiria/assets/css/icons.css",
                "~/Admiria/assets/css/style.css"));

            bundles.Add(new ScriptBundle("~/Admiria/js").Include(
                "~/Admiria/assets/js/jquery.min.js",
                "~/Admiria/assets/js/bootstrap.bundle.min.js",
                "~/Admiria/assets/js/modernizr.min.js",
                "~/Admiria/assets/js/waves.js",
                "~/Admiria/assets/js/jquery.slimscroll.js",
                "~/Admiria/assets/js/jquery.nicescroll.js",
                "~/Admiria/assets/js/jquery.scrollTo.min.js",
                "~/Admiria/assets/js/app.js"));
        }
    }
}
