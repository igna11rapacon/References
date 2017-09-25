using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Rotativa;
using Rotativa.Options;
using System.Web.Mvc;

namespace RotativaTest.Controllers
{
    public class TestReportMvcController : Controller
    {
        public ActionResult TestTemplate()
        {
            JObject jObject = new JObject();
            return _viewAsPdf(jObject);
        }

        [AllowAnonymous]
        public ActionResult Footer()
        {
            return View();
        }

        public byte[] TestTemplatePdfBytes(JObject model)
        {
            ViewAsPdf viewAsPdf = _viewAsPdf(model);
            byte[] applicationPDFData = viewAsPdf.BuildPdf(ControllerContext);
            return applicationPDFData;
        }
        
        private ViewAsPdf _viewAsPdf(JObject model)
        {
            string header = Server.MapPath("~/Views/Templates/TestTemplateHeader.html");
            string footer = Server.MapPath("~/Views/Templates/TestTemplateFooter.html");

            string customSwitches = string.Format(
                //"--header-html  \"{0}\" " +
                "--footer-html \"{1}\" "
                , header, footer);

            dynamic dynamicObject = JsonConvert.DeserializeObject(model.ToString());
            var viewAsPdf = new ViewAsPdf("~/Views/Templates/TestTemplate.cshtml", dynamicObject)
            {
                PageSize = Size.Letter,
                PageOrientation = Orientation.Portrait,
                PageMargins = { Left = 6, Right = 7 },
                CustomSwitches = customSwitches
            };

            return viewAsPdf;
        }
    }
}