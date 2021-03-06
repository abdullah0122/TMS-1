﻿using System.Web;
using System.Web.Optimization;

namespace TMS
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


            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                    "~/Scripts/jquery-{version}.js",
                    "~/Scripts/angular.js",
                    "~/Scripts/angular-route.js",
                    "~/Scripts/foundation.js",
                    "~/Scripts/foundation.topbar.js",
                    "~/Scripts/foundation.reveal.js",
                    "~/Scripts/foundation.abide.js",
                    "~/Scripts/foundation.offcanvas.js",
   
                    "~/Scripts/Application/app.js",
                    
                    "~/Scripts/Application/Services/apiService.js",
                    "~/Scripts/Application/Services/identityService.js",

                    "~/Scripts/Application/Controllers/Training/ListTrainingController.js",
                     "~/Scripts/Application/Controllers/Training/DetailsTrainingController.js",
                    "~/Scripts/Application/Controllers/Training/DeleteTrainingController.js",
                     "~/Scripts/Application/Controllers/Training/EditTrainingController.js",
                    "~/Scripts/Application/Controllers/Training/AddTrainingController.js",
                    "~/Scripts/Application/Controllers/Default/UConstructionController.js",

                    "~/Scripts/Application/Controllers/TrainingCategory/AddTrainingCategoryController.js",
                    "~/Scripts/Application/Controllers/TrainingCategory/ListTrainingCategoryController.js",
                    "~/Scripts/Application/Controllers/TrainingCategory/DeleteTrainingCategoryController.js",
                    "~/Scripts/Application/Controllers/TrainingCategory/EditTrainingCategoryController.js",
                    "~/Scripts/Application/Controllers/TrainingCategory/DetailsTrainingCategoryController.js",


                     "~/Scripts/Application/Controllers/ATS/AddATSController.js" ,
                     "~/Scripts/Application/Controllers/ATS/DeleteATSController.js" ,
                     "~/Scripts/Application/Controllers/ATS/DetailsATSController.js" ,
                     "~/Scripts/Application/Controllers/ATS/EditATSController.js" ,
                     "~/Scripts/Application/Controllers/ATS/ListATSController.js" ,
                    
                     "~/Scripts/Application/Controllers/Account/RegisterController.js",
                      "~/Scripts/Application/Controllers/Account/LoginController.js",

                       "~/Scripts/Application/Controllers/BaseController.js"

                      

                    ));


            

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      //"~/Content/style.dark.css",
                      //"~/Content/style.default.css",
                      "~/Content/site.css"));

            //bundles.Add(new StyleBundle("~/Content/themes/css").Include(
            //          "~/Content/themes/site/css/style.default.css",
            //          "~/Content/themes/site/css/style.dark.css",
            //          "~/Content/themes/site/prettify/prettify.cs"));

            bundles.Add(new StyleBundle("~/Content/themes/js").Include(
                      // "~/Content/themes/site/js/bootstrap.js",
                     //"~/Content/themes/site/css/style.dark.css",
                    // "~/Content/themes/site/js/jquery.dataTables.nightly.js",
                    // "~/Content/themes/site/js/jquery-{version}.js"
                    //"~/Content/themes/site/js/jquery.cookie.js"
                     ));

            BundleTable.EnableOptimizations = false;

        }
    }
}
