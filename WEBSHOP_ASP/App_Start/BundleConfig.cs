using System.Web;
using System.Web.Optimization;

namespace WEBSHOP_ASP
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //link các file script
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            //link các file css
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Asset/css").Include(
                     "~/Asset/css/bootstrap.min.css",
                     "~/Asset/css/font-awesome.min.css",
                     "~/Asset/css/elegant-icons.css",
                     "~/Asset/css/magnific-popup.css",
                     "~/Asset/css/nice-select.css",
                     "~/Asset/css/owl.carousel.min.css",
                     "~/Asset/css/slicknav.min.css",
                     "~/Asset/css/style.css"
                     ));

            bundles.Add(new ScriptBundle("~/Asset/jquery").Include(
                       "~/Asset/js/jquery-3.3.1.min.js",
                       "~/Asset/js/bootstrap.min.js",
                       "~/Asset/js/jquery.nice-select.min.js",
                       "~/Asset/js/jquery.nicescroll.min.js",
                       "~/Asset/js/jquery.magnific-popup.min.js",
                       "~/Asset/js/jquery.countdown.min.js",
                       "~/Asset/js/jquery.slicknav.js",
                       "~/Asset/js/mixitup.min.js",
                       "~/Asset/js/owl.carousel.min.js",
                       "~/Asset/js/main.js"
                       ));
        }
    }
}
