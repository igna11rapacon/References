using SampleMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMvc.Controllers
{
    public class SampleController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            SampleModel sampleModel = new SampleModel
            {
                SampleProperty1 = "SampleProperty1",
                SampleProperty2 = "SampleProperty2"
            };
            return View(sampleModel);
        }

        [HttpPost]
        public ActionResult Index(SampleModel sampleModel)
        {
            return View(sampleModel);
        }

        [HttpGet]
        public JsonResult JsonResult()
        {
            SampleModel sampleModel = new SampleModel
            {
                SampleProperty1 = "SampleProperty1",
                SampleProperty2 = "SampleProperty2"
            };
            return Json(sampleModel, JsonRequestBehavior.AllowGet);
        }
    }
}