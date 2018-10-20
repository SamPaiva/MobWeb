using System.Web;
using System.Web.Optimization;

namespace MobWeb.Site
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/admin-lte/css/AdminLTE.css",
                      "~/admin-lte/css/skins/skin-blue.css",
                      "~/admin-lte/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css"
                      ));

            bundles.Add(new ScriptBundle("~/admin-lte/js").Include(
              "~/admin-lte/js/app.js",
              "~/admin-lte/plugins/fastclick/fastclick.js",
              "~/admin-lte/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js"
              ));

            bundles.Add(new ScriptBundle("~/bundles/inputmask").Include("~/admin-lte/plugins/input-mask/jquery.inputmask.js",
                "~/admin-lte/plugins/input-mask/jquery.inputmask.extensions.js",
                "~/admin-lte/plugins/input-mask/jquery.inputmask.date.extensions.js",
                "~/admin-lte/plugins/input-mask/jquery.inputmask.numeric.extensions.js",
                "~/admin-lte/plugins/input-mask/jquery.inputmask.phone.extensions.js",
                "~/admin-lte/plugins/input-mask/jquery.inputmask.regex.extensions.js"));
        }
    }
}
