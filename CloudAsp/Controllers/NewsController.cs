using System;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using CloudAsp.Models;
using CloudAsp.Models.News;
using CloudAspData;
using CloudAspData.Entity;
using HtmlAgilityPack;

namespace CloudAsp.Controllers
{
    public class NewsController : Controller
    {
       
        public ActionResult Index()
        {
            string Url = "https://ria.ru/lenta/";
            HtmlWeb web = new HtmlWeb();

            HtmlAgilityPack.HtmlDocument doc = web.Load(Url);
            var node = doc.DocumentNode.SelectSingleNode("//div[@class='b-list']");
            var nodes = node.ChildNodes;




            foreach (HtmlNode lin in nodes)
            {

                var mynode = lin.ChildNodes;
                foreach (HtmlNode aref in mynode)
                {
                    string old_url = aref.GetAttributeValue("href", String.Empty) + Environment.NewLine;
                    string new_url = String.Concat("https://ria.ru/", old_url);
                    aref.SetAttributeValue("href", new_url);
                }

            }


            ViewBag.HtmlContent =  node.OuterHtml;

            return View();
        }

    }
}