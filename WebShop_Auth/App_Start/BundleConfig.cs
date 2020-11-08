using System.Web;
using System.Web.Optimization;

namespace WebShop_Auth
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/Custom.js",
                         "~/Scripts/jquery-3.3.1.min.js",
                          "~/Scripts/bootstrap.min.js",
                          "~/Scripts/jquery.nice-select.min.js",
                          "~/Scripts/jquery.nicescroll.min.js",
                          "~/Scripts/jquery.magnific-popup.min.js",
                          "~/Scripts/jquery.countdown.min.js",
                          "~/Scripts/jquery.slicknav.js",
                          "~/Scripts/mixitup.min.js",
                          "~/Scripts/owl.carousel.min.js",
                          "~/Scripts/main.js"));

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
            //link scripit cua tempalte
            bundles.Add(new ScriptBundle("~/Content/Asset/jquery").Include(
                      "~/Scripts/jquery-3.3.1.min.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/jquery.nice-select.min.js",
                      "~/Scripts/jquery.nicescroll.min.js",
                      "~/Scripts/jquery.magnific-popup.min.js",
                      "~/Scripts/jquery.countdown.min.js",
                      "~/Scripts/jquery.slicknav.js",
                      "~/Scripts/mixitup.min.js",
                      "~/Scripts/owl.carousel.min.js",
                      "~/Scripts/main.js"
                      
                      ));
          
            bundles.Add(new StyleBundle("~/Content/styles").Include(
                "~/Content/style.css",
                "~/Content/bootstrap.min.css",
                "~/Content/bootstrap-theme.css",
                  "~/Content/font-awesome.min.css",
                  "~/Content/elegant-icons.css",
                  "~/Content/magnific-popup.css",
                  "~/Content/nice-select.css",
                  "~/Content/owl.carousel.min.css",
                  "~/Content/slicknav.min.css",
                  "~/Content/cartdetail.css"
                ));
        }
    }
}
