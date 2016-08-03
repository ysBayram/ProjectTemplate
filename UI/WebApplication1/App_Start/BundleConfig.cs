using System.Web.Optimization;

namespace WebApplication1
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/mainlayoutcss").Include(
                      "~/css/bootstrap.min.css",
                      "~/font-awesome/css/font-awesome.css",
                      "~/css/plugins/iCheck/custom.css",
                      "~/css/animate.css",
                      "~/css/style.css"));

            bundles.Add(new ScriptBundle("~/bundles/mainlayoutjs").Include(
                        "~/js/jquery-{version}.js",
                        "~/js/bootstrap.min.js",
                        "~/js/jquery-ui.min.js",
                        "~/js/plugins/metisMenu/jquery.metisMenu.js",
                        "~/js/plugins/slimscroll/jquery.slimscroll.min.js",
                        "~/js/inspinia.js",
                        "~/js/plugins/pace/pace.min.js",
                        "~/js/jquery-ui.custom.min.js"));

            bundles.Add(new StyleBundle("~/bundles/datatablecss").Include(
                      "~/css/plugins/dataTables/dataTables.responsive.css",
                      "~/css/plugins/dataTables/jquery.dataTables.css"));

            bundles.Add(new ScriptBundle("~/bundles/datatablejs").Include(
                        "~/js/plugins/dataTables/jquery.dataTables.js",
                        "~/js/plugins/dataTables/dataTables.responsive.js"));

            bundles.Add(new StyleBundle("~/bundles/fullcalendercss").Include(
                     "~/css/plugins/fullcalendar/fullcalendar.css",
                     "~/css/plugins/fullcalendar/fullcalendar.print.css"));

            bundles.Add(new ScriptBundle("~/bundles/fullcalenderjs").Include(
                        "~/js/plugins/fullcalendar/moment.min.js",
                        "~/js/plugins/iCheck/icheck.min.js",
                        "~/js/plugins/fullcalendar/fullcalendar.min.js",
                        "~/js/plugins/fullcalendar/lang-all.js"));

         

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }
    }
}
