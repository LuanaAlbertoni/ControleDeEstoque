using System.Web;
using System.Web.Optimization;

namespace ControleDeEstoque.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/sbadmin/js").Include(
                      "~/Content/jquery/dist/jquery.min.js",
                      "~/Content/bootstrap/dist/js/bootstrap.min.js",
                      "~/Content/metisMenu/dist/metisMenu.min.js",
                      "~/Content/bootstrap/js/bootstrap-datepicker.min.js",
                      "~/Content/bootstrap/locales/bootstrap-datepicker.pt-BR.min.js",
                      "~/Content/bootstrap/js/moment.min.js",
                      "~/Content/bootstrap/js/moment-locale-ptBR.js",
                      "~/Content/bootstrap/js/daterangepicker.js",
                      "~/Content/raphael/raphael-min.js",
                //   "~/Content/morrisjs/morris.min.js",
                //  "~/Content/sbadmin/js/morris-data.js",
                      "~/Content/datatables/media/js/jquery.dataTables.min.js",
                      "~/Content/datatables-plugins/integration/bootstrap/3/dataTables.bootstrap.min.js",
                      "~/Content/sbadmin/dist/js/sb-admin-2.js"


                      ));

            bundles.Add(new StyleBundle("~/Content/sbadmin/css").Include(
                      "~/Content/bootstrap/dist/css/bootstrap.min.css",
                      "~/Content/metisMenu/dist/metisMenu.min.css",
                //"~/Content/sbadmin/dist/css/timeline.css",
                      "~/Content/bootstrap/dist/css/bootstrap.min.css",
                      "~/Content/bootstrap/css/bootstrap-datepicker.min.css",
                      "~/Content/bootstrap/css/daterangepicker.css",
                      "~/Content/datatables/media/css/dataTables.bootstrap.min.css",
                      "~/Content/datatables-responsive/css/dataTables.responsive.css",
                      "~/Content/sbadmin/dist/css/sb-admin-2.css",
                //"~/Content/sbadmin/morrisjs/morris.css",
                      "~/Content/font-awesome/css/font-awesome.min.css"
                      ));


        }
    }
}
