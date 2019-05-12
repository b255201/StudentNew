using StudentWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentWeb.Controllers
{
  
    public class DialogController : Controller
    {
        private Repository<StudentWeb.Models.LastNew> LastNew = new Repository<StudentWeb.Models.LastNew>();
        private Repository<StudentWeb.Models.LessonOpt> LessonRepo = new Repository<StudentWeb.Models.LessonOpt>();
        // GET: Dialog
        public ActionResult Index()
        {
            return View();
        }
        #region Login, 登入對話框
        /// <summary>
        ///  登入對話框
        /// </summary>
        /// <returns></returns>
        public ActionResult LastNewInfo(int Id = 1)
        {
            var q = LastNew.GetByID(Id);
            return PartialView("LastNewDialogPartial",q);
        }
        #endregion

        #region lessonOpt, 課程表選擇器
        /// <summary>
        ///  課程表選擇器
        /// </summary>
        /// <returns></returns>
        public ActionResult LessonOpt()
        {
            var q = LessonRepo.GetAll().OrderBy(i => i.Seq).ToList();
            ViewBag.Opt = q;
            return PartialView("LessonOptPartial");
        }
        #endregion
        public ActionResult Search()
        {
            var q = LessonRepo.GetAll().OrderBy(i => i.Seq).ToList();
  
            return Json(new { Status = "0", StatusDesc = q });
        }
    }
}