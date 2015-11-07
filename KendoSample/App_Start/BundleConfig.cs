using System.Web;
using System.Web.Optimization;

namespace KendoSample
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/Kendo").Include(
                      "~/Scripts/kendo.all.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/etalage.css",
                      "~/Content/form.css",
                      "~/Content/fwslider.css",
                      "~/Content/jquery-ui.css",
                      "~/Content/theme.css",
                      "~/Content/Kendo/kendo.default.min.css",
                      "~/Content/Kendo/kendo.common.min.css",
                      "~/Content/Kendo/kendo.rtl.min.css",
                      "~/Content/site.css"));
        }
    }
}
