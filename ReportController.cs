using StarchProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Linq;

namespace StarchProject.Controllers
{
    
    public class ReportController : Controller
    {
        //
        // GET: /Dashboard/
        public JsonResult ReportUnitData1(int date, int month, int year)
        {            
            FinalProjectEntities data = new FinalProjectEntities();
            var timestamp = DateTime.Now;
            string[] array = {  //Data Fine1
                                 "PV(FIC-071)", "PV(FIC-072)", "SFU07",
                                 //Data Fine2
                                 "PV(FIC-181)", "SFU18", 
                                 //Data Fine3
                                 "SFU16", "SIFU16",
                                 //Data CEX
                                 "PV(FIC-051)", "PV(FIC-052)", "SFU05",
                                 //Data PEX1
                                 "PV(FIC-091)","WAFU09" , "SFU09", 
                                 //Data PEX2
                                 "PV(FIC-111)","WAFU11" , "SFU11", 
                                 //Data PEX3
                                  "SFU12", "PIFU12"                             
                             
                             };
            var v = from a in data.HistoryDatas
                    where a.gettime.Day == date && a.gettime.Month == month && a.gettime.Year == year && 
                          array.Contains(a.parameter)
                    orderby a.gettime ascending
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = Int32.MaxValue;

            return jsonResult;
        }

        public JsonResult ReportUnitData2(int date, int month, int year)
        {
            FinalProjectEntities data = new FinalProjectEntities();
            var timestamp = DateTime.Now;
            string[] array = {  
                                 //Data BeltPulp
                                 "CEX04INU12", "POFU12", 
                                 //Data SEP0
                                 "SFU21", "WAIFU21",
                                 //Data SEP1
                                 "PV(FIC-151)", "SLFU15", 
                                 //Data SEP2
                                 "PV(FIC-201)", "SFU20",
                                 //Data SEP3
                                 "PV(FIC-231)", "SFU23", "WAFU23", 
                                 
                             
                             };
            var v = from a in data.HistoryDatas
                    where a.gettime.Day == date && a.gettime.Month == month && a.gettime.Year == year &&
                          array.Contains(a.parameter)
                    orderby a.gettime ascending
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = Int32.MaxValue;

            return jsonResult;
        }
        public JsonResult ReportUnitData3(int date, int month, int year)
        {
            FinalProjectEntities data = new FinalProjectEntities();
            var timestamp = DateTime.Now;
            string[] array = {                                  
                                 //Data Dewatering
                                 "PV(FIC-251)", "SFU25", 
                                 //Data Drying
                                  "SFU26", "SIFU26",
                                 //Data Packaging
                                 "CPFU29", "CPOFU29","CPIFU29",                                 
                                 //Data computing
                                 "CIFU01","WAFU02","W2FEXU02","SOFU01",
                                 //Material  consumption
                                 "SUFU8","WFU12", "WFU22" ,  "PV(FIC-152)","WIFU20"
                             
                             };
            var v = from a in data.HistoryDatas
                    where a.gettime.Day == date && a.gettime.Month == month && a.gettime.Year == year &&
                          array.Contains(a.parameter)
                    orderby a.gettime ascending
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = Int32.MaxValue;

            return jsonResult;
        }
        public JsonResult ReportOwnerData(int date, int month, int year)
        {
            FinalProjectEntities data = new FinalProjectEntities();
            string[] array = {                                   
                                 //Data computing
                                 "CIFU01","WAFU02","W2FEXU02","SOFU01","CPFU29","POFU12","CPOFU29",
                                 //Material  consumption
                                 "SUFU8","WFU12", "WFU22" ,  "PV(FIC-152)","WIFU20"
                             
                             };
            var v = from a in data.HistoryDatas
                    where a.gettime.Day == date && a.gettime.Month == month && a.gettime.Year == year &&
                          array.Contains(a.parameter)
                    orderby a.gettime ascending
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = Int32.MaxValue;

            return jsonResult;
        }
        public JsonResult GetStarchQuality(int date, int month, int year)
        {
            FinalProjectEntities data = new FinalProjectEntities();
            var timestamp = DateTime.Now;

            var v = from a in data.StarchQualities
                    where a.AddTime.Day == date && a.AddTime.Month == month && a.AddTime.Year == year
                    orderby a.AddTime ascending
                    select a;

            var jsonResult = Json(v, JsonRequestBehavior.AllowGet);

            return jsonResult;
        }
        //public JsonResult ReportUnitData()
        //{
        //    FinalProjectEntities data = new FinalProjectEntities();
        //    var timestamp = DateTime.Now;
        //    string[] array = {  //Data Fine1
        //                         "PV(FIC-071)", "PV(FIC-072)", "SFU07", "PFU07","SUFU8",
        //                         //Data Fine2
        //                         "PV(FIC-181)", "SFU18", "PFU18",
        //                         //Data Fine3
        //                         "SFU16", "PFU16",
        //                         //Data CEX
        //                         "PV(FIC-051)", "PV(FIC-052)", "SFU05", "PFU05" ,
        //                         //Data PEX1
        //                         "PV(FIC-091)","WAFU09" , "SFU09", "PFU09", 
        //                         //Data PEX2
        //                         "PV(FIC-111)","WAFU11" , "SFU11", "PFU11",
        //                         //Data PEX3
        //                          "SFU12", "PFU12", "WFU12",
        //                         //Data BeltPulp
        //                         "CEX04INU12", "POFU12", "WAFU12",
        //                         //Data SEP0
        //                         "SFU21", "WAFU21" ,
        //                         //Data SEP1
        //                         "PV(FIC-151)", "PV(FIC-152)", "SLFU15", "LPFU15", "MPFU15",
        //                         //Data SEP2
        //                         "PV(FIC-201)", "SFU20", "PFU20",
        //                         //Data SEP3
        //                         "PV(FIC-231)", "SFU23", "WAFU23", "WFU22" ,
        //                         //Data Dewatering
        //                         "PV(FIC-251)", "SFU25", "CFU25" ,
        //                         //Data Drying
        //                          "SFU26", "WFU26" ,
        //                         //Data Packaging
        //                         "CPFU29", "CPOFU29",                                 
                                 
        //                         "CIFU01","WAFU02","W2FEXU02","SOFU01"
                             
        //                     };
        //    var v = from a in data.HistoryDatas
        //            //where a.gettime.Day == timestamp.Day && a.gettime.Month == timestamp.Month && a.gettime.Year == timestamp.Year && 
        //            where array.Contains(a.parameter)
        //            orderby a.gettime ascending
        //            select a;

        //    var jsonResult = Json(v, JsonRequestBehavior.AllowGet);
        //    jsonResult.MaxJsonLength = Int32.MaxValue;

        //    return jsonResult;
        //}

        public ActionResult Owner()
        {
            return View();
        }
        public ActionResult PlantManager()
        {
            return View();
        }
        

    }
}
