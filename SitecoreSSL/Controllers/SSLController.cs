using SitecoreSSL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;

namespace SitecoreSSL.Controllers
{
    public class SSLController : Controller
    {
        public ActionResult SSL()
        {
            string url = "https://www.ssllabs.com/ssltest/analyze.html?d=" + Request.Url.Host;
            string browserURL = "http://browsershots.org/" + Request.Url;
            string seoURL = "https://app.neilpatel.com/en/seo_analyzer/site_audit?domain=" + Request.Url.Host + "&submit=Analyze+Website";
            string pageSpeedURL="https://developers.google.com/speed/pagespeed/insights/?url="+ Request.Url.Host;
            string digitalURL ="https://www.woorank.com/en/www/" + Request.Url.Host;
            string loadURL = "https://app.loadimpact.com/k6/anonymous-test/custom?url=http%3A%2F%2F" + Request.Url.Host + "&utm_campaign=Anon%20Test&utm_source=marketing%20CTA&utm_medium=website";
            var model = new SSLModel();
            model.PageSpeedURL = pageSpeedURL;
            model.LoadURL = loadURL;
            model.URL = url;
            model.BrowserURL = browserURL;
            model.SEOURL = seoURL;
            model.DigitalURL = digitalURL;
            return View(model);
        }
    }
}