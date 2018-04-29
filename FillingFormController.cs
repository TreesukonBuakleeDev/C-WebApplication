using StarchProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Linq;


namespace StarchProject.Controllers
{
    public class FillingFormController : Controller
    {
        //
        // GET: /FillingForm/


        public JsonResult GetStarchQuality() 
        {
            FinalProjectEntities data = new FinalProjectEntities();
            var timestamp = DateTime.Now;

            var v = from a in data.StarchQualities
                     where a.AddTime.Day == timestamp.Day && a.AddTime.Month == timestamp.Month && a.AddTime.Year == timestamp.Year
                     orderby a.AddTime ascending
                     select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);

            return jsonResult;
        }
        public ContentResult AddStarchQuality(float value1, float value2, float value3, float value4)
        {
            FinalProjectEntities data = new FinalProjectEntities();
            StarchQuality NewRecord = new StarchQuality();
            var timestamp = DateTime.Now;

            NewRecord.AddTime = timestamp;
            NewRecord.PH = value1;
            NewRecord.Whiteness = value2;
            NewRecord.Viscosity = value3;
            NewRecord.SulfurResidue = value4;
            data.StarchQualities.Add(NewRecord);
            data.SaveChanges();
            return Content("Insert data success.");
            
        }

        public ActionResult FormShared()
        {
            return View();
        }
        public ActionResult CassavaForm()
        {
            return View();
        }
        public ActionResult StarchQualityForm()
        {
            return View();
        }

    }
}
