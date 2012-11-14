using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

namespace TestFormFill.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            WebRequest request = HttpWebRequest.Create("http://www.tredz.co.uk");

            WebResponse response = request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string urlText = reader.ReadToEnd();


            return View();
        }
    }
}
