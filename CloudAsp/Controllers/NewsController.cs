using System;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using CloudAsp.Models;
using CloudAsp.Models.News;
using CloudAspData;
using CloudAspData.Entity;

namespace CloudAsp.Controllers
{
    public class NewsController : Controller
    {
       
        public ActionResult Index()
        {
          

            return View();
        }

    }
}