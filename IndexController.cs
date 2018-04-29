using StarchProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace StarchProject.Controllers
{
    public class IndexController : Controller
    {
        //string connectionstring = "server= SOM;Trusted_Connection=yes; database= FinalProject;connection timeout=30";
       
        public JsonResult DataDashboardHistory()
        {
            FinalProjectEntities data = new FinalProjectEntities();

            string[] array = { "CIFU01", "CPFU29", "WAFU02", "POFU12", "W2FEXU02" };
            var v = from a in data.HistoryDatas
                    where array.Contains(a.parameter)
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);

            return jsonResult;

        }
        public JsonResult GetStarchQuality()
        {
            FinalProjectEntities data = new FinalProjectEntities();
            var timestamp = DateTime.Now;

            var v = (from a in data.StarchQualities
                     where a.AddTime.Day == timestamp.Day && a.AddTime.Month == timestamp.Month && a.AddTime.Year == timestamp.Year
                     orderby a.AddTime ascending
                     select a).Take(1);

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);

            return jsonResult;
        }
        public JsonResult DataMaterialPreparation()
        {
            FinalProjectEntities data = new FinalProjectEntities();

            string[] array = { "CIFU01", "SOFU01", "WAFU02", "W2FEXU02" };
            var v = from a in data.HistoryDatas
                    where array.Contains(a.parameter)
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);

            return jsonResult;

        }
        public JsonResult DataFine1(string valueS)
        {
            FinalProjectEntities data = new FinalProjectEntities();

            string[] array = { "PV(FIC-071)", "PV(FIC-073)", "SFU07", "PFU07", "SUFU8" };
            var v = from a in data.CurrentDatas
                    where array.Contains(a.parameter)
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);

            return jsonResult;

        }
        public JsonResult DataFine1History()
        {
            FinalProjectEntities data = new FinalProjectEntities();
            string[] array = { "PV(FIC-071)", "PV(FIC-073)", "SFU07", "PFU07" ,"SUFU8"};

            var v = from a in data.HistoryDatas
                    //where array.Contains(a.parameter) && a.gettime.Day == 20
                    where array.Contains(a.parameter)
                    orderby a.gettime ascending
                    select a;
            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);
            return jsonResult;
        }
        public JsonResult DataFine2(string valueS)
        {
            FinalProjectEntities data = new FinalProjectEntities();

            string[] array = { "PV(FIC-181)", "SFU18", "PFU18" };
            var v = from a in data.CurrentDatas
                    where array.Contains(a.parameter)
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);

            return jsonResult;

        }
        public JsonResult DataFine2History()
        {
            FinalProjectEntities data = new FinalProjectEntities();
            string[] array = { "PV(FIC-181)", "SFU18", "PFU18" };
            var v = from a in data.HistoryDatas
                    where array.Contains(a.parameter)
                    orderby a.gettime ascending
                    select a;
            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);
            return jsonResult;
        }

        public JsonResult DataFine3(string valueS)
        {
            FinalProjectEntities data = new FinalProjectEntities();

            string[] array = { "SFU16", "PFU16", "SIFU16" };
            var v = from a in data.CurrentDatas
                    where array.Contains(a.parameter)
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);

            return jsonResult;

        }
        public JsonResult DataFine3History()
        {
            FinalProjectEntities data = new FinalProjectEntities();
            string[] array = { "SFU16", "PFU16", "SIFU16" };
            var v = from a in data.HistoryDatas
                    where array.Contains(a.parameter)
                    orderby a.gettime ascending
                    select a;
            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);
            return jsonResult;
        }

        public JsonResult DataCoarseExtractor(string valueS)
        {
            FinalProjectEntities data = new FinalProjectEntities();

            string[] array = { "PV(FIC-051)", "PV(FIC-052)", "SFU05", "PFU05" };
            var v = from a in data.CurrentDatas
                    where array.Contains(a.parameter)
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);

            return jsonResult;

        }
        public JsonResult DataCoarseExtractorHistory()
        {
            FinalProjectEntities data = new FinalProjectEntities();
            string[] array = { "PV(FIC-051)", "PV(FIC-052)", "SFU05", "PFU05" };
            var v = from a in data.HistoryDatas
                    where array.Contains(a.parameter)
                    orderby a.gettime ascending
                    select a;
            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);
            return jsonResult;
        }
        public JsonResult DataPulpExtractor1(string valueS)
        {
            FinalProjectEntities data = new FinalProjectEntities();

            string[] array = { "PV(FIC-091)", "SFU09", "PFU09", "WAFU09" };
            var v = from a in data.CurrentDatas
                    where array.Contains(a.parameter)
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);

            return jsonResult;

        }
        public JsonResult DataPulpExtractor1History()
        {
            FinalProjectEntities data = new FinalProjectEntities();
            string[] array = { "PV(FIC-091)", "SFU09", "PFU09", "WAFU09" };
            var v = from a in data.HistoryDatas
                    where array.Contains(a.parameter)
                    orderby a.gettime ascending
                    select a;
            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);
            return jsonResult;
        }
        public JsonResult DataPulpExtractor2(string valueS)
        {
            FinalProjectEntities data = new FinalProjectEntities();

            string[] array = { "PV(FIC-111)", "SFU11", "PFU11", "WAFU11" };
            var v = from a in data.CurrentDatas
                    where array.Contains(a.parameter)
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);

            return jsonResult;

        }
        public JsonResult DataPulpExtractor2History()
        {
            FinalProjectEntities data = new FinalProjectEntities();
            string[] array = { "PV(FIC-111)", "SFU11", "PFU11", "WAFU11" };
            var v = from a in data.HistoryDatas
                    where array.Contains(a.parameter)
                    orderby a.gettime ascending
                    select a;
            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);
            return jsonResult;
        }
        public JsonResult DataPulpExtractor3(string valueS)
        {
            FinalProjectEntities data = new FinalProjectEntities();

            string[] array = { "SFU12", "PFU12", "WFU12", "PIFU12" };
            var v = from a in data.CurrentDatas
                    where array.Contains(a.parameter)
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);

            return jsonResult;

        }
        public JsonResult DataPulpExtractor3History()
        {
            FinalProjectEntities data = new FinalProjectEntities();
            string[] array = { "SFU12", "PFU12", "WFU12", "PIFU12" };
            var v = from a in data.HistoryDatas
                    where array.Contains(a.parameter)
                    orderby a.gettime ascending
                    select a;
            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);
            return jsonResult;
        }
        public JsonResult DataBeltPulp(string valueS)
        {
            FinalProjectEntities data = new FinalProjectEntities();

            string[] array = { "CEX04INU12", "POFU12", "WAFU12" };
            var v = from a in data.CurrentDatas
                    where array.Contains(a.parameter)
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);

            return jsonResult;

        }
        public JsonResult DataBeltPulpHistory()
        {
            FinalProjectEntities data = new FinalProjectEntities();
            string[] array = { "CEX04INU12", "POFU12", "WAFU12" };
            var v = from a in data.HistoryDatas
                    where array.Contains(a.parameter)
                    orderby a.gettime ascending
                    select a;
            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);
            return jsonResult;
        }
        public JsonResult DataSeperator0(string valueS)
        {
            FinalProjectEntities data = new FinalProjectEntities();

            string[] array = { "SFU21", "WAFU21", "WAIFU21" };
            var v = from a in data.CurrentDatas
                    where array.Contains(a.parameter)
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);

            return jsonResult;

        }
        public JsonResult DataSeperator0History()
        {
            FinalProjectEntities data = new FinalProjectEntities();
            string[] array = { "SFU21", "WAFU21", "WAIFU21" };
            var v = from a in data.HistoryDatas
                    where array.Contains(a.parameter)
                    orderby a.gettime ascending
                    select a;
            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);
            return jsonResult;
        }
        public JsonResult DataSeperator1(string valueS)
        {
            FinalProjectEntities data = new FinalProjectEntities();

            string[] array = { "PV(FIC-151)", "PV(FIC-152)", "SLFU15", "LPFU15", "MPFU15" };
            var v = from a in data.CurrentDatas
                    where array.Contains(a.parameter)
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);

            return jsonResult;

        }
        public JsonResult DataSeperator1History()
        {
            FinalProjectEntities data = new FinalProjectEntities();
            string[] array = { "PV(FIC-151)", "PV(FIC-152)", "SLFU15", "LPFU15", "MPFU15" };
            var v = from a in data.HistoryDatas
                    where array.Contains(a.parameter)
                    orderby a.gettime ascending
                    select a;
            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);
            return jsonResult;
        }
        public JsonResult DataSeperator2(string valueS)
        {
            FinalProjectEntities data = new FinalProjectEntities();

            string[] array = { "PV(FIC-201)", "SFU20", "PFU20", "WIFU20" };
            var v = from a in data.CurrentDatas
                    where array.Contains(a.parameter)
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);

            return jsonResult;

        }
        public JsonResult DataSeperator2History()
        {
            FinalProjectEntities data = new FinalProjectEntities();
            string[] array = { "PV(FIC-201)", "SFU20", "PFU20", "WIFU20" };
            var v = from a in data.HistoryDatas
                    where array.Contains(a.parameter)
                    orderby a.gettime ascending
                    select a;
            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);
            return jsonResult;
        }
        public JsonResult DataSeperator3(string valueS)
        {
            FinalProjectEntities data = new FinalProjectEntities();

            string[] array = { "PV(FIC-231)", "SFU23", "WAFU23", "WFU22" };
            var v = from a in data.CurrentDatas
                    where array.Contains(a.parameter)
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);

            return jsonResult;

        }
        public JsonResult DataSeperator3History()
        {
            FinalProjectEntities data = new FinalProjectEntities();
            string[] array = { "PV(FIC-231)", "SFU23", "WAFU23", "WFU22" };
            var v = from a in data.HistoryDatas
                    where array.Contains(a.parameter)
                    orderby a.gettime ascending
                    select a;
            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);
            return jsonResult;
        }
        public JsonResult DataDewatering(string valueS)
        {
            FinalProjectEntities data = new FinalProjectEntities();

            string[] array = { "PV(FIC-251)", "SFU25", "CFU25" };
            var v = from a in data.CurrentDatas
                    where array.Contains(a.parameter)
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);

            return jsonResult;

        }
        public JsonResult DataDewateringHistory()
        {
            FinalProjectEntities data = new FinalProjectEntities();
            string[] array = { "PV(FIC-251)", "SFU25", "CFU25" };
            var v = from a in data.HistoryDatas
                    where array.Contains(a.parameter)
                    orderby a.gettime ascending
                    select a;
            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);
            return jsonResult;
        }
        public JsonResult DataDrying(string valueS)
        {
            FinalProjectEntities data = new FinalProjectEntities();

            string[] array = { "SFU26", "WFU26", "SIFU26" };
            var v = from a in data.CurrentDatas
                    where array.Contains(a.parameter)
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);

            return jsonResult;

        }
        public JsonResult DataDryingHistory()
        {
            FinalProjectEntities data = new FinalProjectEntities();
            string[] array = { "SFU26", "WFU26", "SIFU26" };
            var v = from a in data.HistoryDatas
                    where array.Contains(a.parameter)
                    orderby a.gettime ascending
                    select a;
            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);
            return jsonResult;
        }
        public JsonResult DataPackaging(string valueS)
        {
            FinalProjectEntities data = new FinalProjectEntities();

            string[] array = { "CPFU29", "CPOFU29", "CPIFU29" };
            var v = from a in data.CurrentDatas
                    where array.Contains(a.parameter)
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);

            return jsonResult;

        }
        public JsonResult DataPackagingHistory()
        {
            FinalProjectEntities data = new FinalProjectEntities();
            string[] array = { "CPFU29", "CPOFU29", "CPIFU29" };
            var v = from a in data.HistoryDatas
                    where array.Contains(a.parameter)
                    orderby a.gettime ascending
                    select a;
            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);
            return jsonResult;
        }
        // GET: /Index/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DashBoard()
        {
            return View();
        }
        public ActionResult Monitor()
        {
            return View();
        }
        public ActionResult MaterialPreparations()
        {
            return View();
        }
        public ActionResult CoarseExtractor()
        {
            return View();
        }
        public ActionResult FineExtractor1()
        {
            return View();
        }
        public ActionResult Seperator1()
        {
            return View();
        }
        public ActionResult FineExtractor2()
        {
            return View();
        }
        public ActionResult FineExtractor3()
        {
            return View();
        }
        public ActionResult Seperator2()
        {
            return View();
        }
        public ActionResult Seperator3()
        {
            return View();
        }
        public ActionResult Seperator0()
        {
            return View();
        }
        public ActionResult Dewatering()
        {
            return View();
        }
        public ActionResult Drying()
        {
            return View();
        }
        public ActionResult PulpExtractor1()
        {
            return View();
        }
        public ActionResult PulpExtractor2()
        {
            return View();
        }
        public ActionResult PulpExtractor3()
        {
            return View();
        }
        public ActionResult BeltPulp()
        {
            return View();
        }
        public ActionResult Packaging()
        {
            return View();
        }
    }
}
