using EventSphere.Database;
using EventSphere.Entities;
using EventSphere.Services;
using EventSphere.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace EventSphere.Controllers
{
    public class SocietyController : Controller
    {
        // GET: Society
        public ActionResult Index()
        {
            var societies = SocietyServices.Instance.GetAllSocieties();
            return View(societies);
        }
        public ActionResult CreateSociety()
        {
            return PartialView("_CreateSociety");
        }
        [HttpPost]
        public ActionResult UpdateSocietyDetail(SocietyDetailviewModel model)
        {
            var target = SocietyDetailServices.Instance.GetdetailsofASociety(model.SocietyID);
            if(target == null)
            {
                target = new SocietyDetails();
            }
            target.SocietyID = model.SocietyID;
            target.SocietySupervisorName = model.SocietySupervisorName;
            target.SocietyPresidentName = model.SocietyPresidentName;
            target.SocietyVicePresidentName = model.SocietyVicePresidentName;
            target.SocietyFinanceSecreteryName = model.SocietyFinanceSecreteryName;
            if(model.SocietySupervisorImage != null && model.SocietySupervisorImage.ContentLength > 0)
            {
                string updatedname = "";
                string ImageName = System.IO.Path.GetFileName(model.SocietySupervisorImage.FileName);
                updatedname = DateTime.Now.ToString("ddMMyyyy") + "_" + ImageName;
                string physicalPath = Server.MapPath("~/SocietyDetailsImages/" + updatedname);
                model.SocietySupervisorImage.SaveAs(physicalPath);
                target.SocietySupervisorImage = updatedname;
            }
            if (model.SocietyPresidentImage != null && model.SocietyPresidentImage.ContentLength > 0)
            {
                string updatedname = "";
                string ImageName = System.IO.Path.GetFileName(model.SocietyPresidentImage.FileName);
                updatedname = DateTime.Now.ToString("ddMMyyyy") + "_" + ImageName;
                string physicalPath = Server.MapPath("~/SocietyDetailsImages/" + updatedname);
                model.SocietyPresidentImage.SaveAs(physicalPath);
                target.SocietyPresidentImage = updatedname;
            }
            if (model.SocietyVicePresidentImage != null && model.SocietyVicePresidentImage.ContentLength > 0)
            {
                string updatedname = "";
                string ImageName = System.IO.Path.GetFileName(model.SocietyVicePresidentImage.FileName);
                updatedname = DateTime.Now.ToString("ddMMyyyy") + "_" + ImageName;
                string physicalPath = Server.MapPath("~/SocietyDetailsImages/" + updatedname);
                model.SocietyVicePresidentImage.SaveAs(physicalPath);
                target.SocietyVicePresidentImage = updatedname;
            }
            if (model.SocietyFinanceSecreteryImage != null && model.SocietyFinanceSecreteryImage.ContentLength > 0)
            {
                string updatedname = "";
                string ImageName = System.IO.Path.GetFileName(model.SocietyFinanceSecreteryImage.FileName);
                updatedname = DateTime.Now.ToString("ddMMyyyy") + "_" + ImageName;
                string physicalPath = Server.MapPath("~/SocietyDetailsImages/" + updatedname);
                model.SocietyFinanceSecreteryImage.SaveAs(physicalPath);
                target.SocietyFinanceSecreteryImage = updatedname;
            }
            if(target.ID == 0)
            {
                SocietyDetailServices.Instance.SaveSocietyDetail(target);
            }
            else
            {
                SocietyDetailServices.Instance.UpdateSocietyDetail(target);
            }
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);

        }
        public ActionResult DisplaySocietyInfo(int ID = 0)
        {
            //Session["navitems"] = SocietyServices.Instance.GetAllSocieties();
            var context = new DSContext();
            var userdetail = context.Users.Where(x => x.SocietyID == ID).FirstOrDefault();
            var details = context.SocietyDetails.Where(x => x.SocietyID == ID).FirstOrDefault();
            var society = context.Societies.Where(x => x.ID == ID).FirstOrDefault();
            SocietyViewModel Model  = new SocietyViewModel();
            Model.user = new User();
            Model.detail = new SocietyDetails();
            Model.society = new Society();
            Model.user = userdetail;
            Model.detail = details;
            Model.society = society;
            return View(Model);
        }
        [HttpPost]
        public ActionResult SaveSociety(Society society)
        {
            SocietyServices.Instance.SaveSociety(society);
            return Json(new { ID = society.ID }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ChangeStatus(string status, int ID)
        {
            if(status == "Inactive") 
            {
                var target = SocietyServices.Instance.GetAllSocieties().Where(x => x.ID == ID).FirstOrDefault();
                target.IsActiveCommunity = false;
                SocietyServices.Instance.UpdateSociety(target);
            }
            else
            {
                var target = SocietyServices.Instance.GetAllSocieties().Where(x => x.ID == ID).FirstOrDefault();
                target.IsActiveCommunity = true;
                SocietyServices.Instance.UpdateSociety(target);
            }
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
        //public ActionResult AddSociety(society)
    }
}