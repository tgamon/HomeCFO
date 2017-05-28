using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeCFOContext;
using System.Data.Entity;

namespace HomeCFO_DX.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new Context())
            {
                context.Database.CreateIfNotExists();
            }


                return View();    
        }



        HomeCFOContext.Context db = new HomeCFOContext.Context();

        [ValidateInput(false)]
        public ActionResult GridViewPartial_Activity()
        {
            var model = db.Activities;
            return PartialView("_GridViewPartial_Activity", model.ToList());
        }
    }
}