using Newtonsoft.Json.Linq;
using RotativaTest.Controllers;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace RotativaTest.Api
{
    public class TestReportApiController : ApiController
    {
        [HttpPost]
        [Route("TestTemplate")]
        public HttpResponseMessage TestTemplate(JObject model)
        {

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "value");

            RouteData route = new RouteData();
            route.Values.Add("action", "GetPDF"); // ActionName
            route.Values.Add("controller", "TestReport"); // Controller Name
            TestReportMvcController _testReportMvc = new TestReportMvcController();
            System.Web.Mvc.ControllerContext newContext = new System.Web.Mvc.ControllerContext(new HttpContextWrapper(HttpContext.Current), route, _testReportMvc);
            _testReportMvc.ControllerContext = newContext;
            response.Content = new ByteArrayContent(_testReportMvc.TestTemplatePdfBytes(model));
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
            return response;
        }
    }
}
