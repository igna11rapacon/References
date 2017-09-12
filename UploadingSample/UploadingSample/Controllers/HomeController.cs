using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UploadingSample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        #region FormUpload
        [HttpPost]
        public ActionResult FormUpload(HttpPostedFileBase file)
        {

            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                fileName = fileName.Split('\\').Last(); //This will fix problems when uploading using IE
                var path = Path.Combine(Server.MapPath("~/App_Data/FormFileUpload"), fileName);
                file.SaveAs(path);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult FormMultipleUpload(IEnumerable<HttpPostedFileBase> files)
        {
            foreach (var file in files)
            {
                if (file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    fileName = fileName.Split('\\').Last(); //This will fix problems when uploading using IE
                    var path = Path.Combine(Server.MapPath("~/App_Data/FormFileUpload"), fileName);
                    file.SaveAs(path);
                }
            }
            return RedirectToAction("Index");
        }
        #endregion
    }
}