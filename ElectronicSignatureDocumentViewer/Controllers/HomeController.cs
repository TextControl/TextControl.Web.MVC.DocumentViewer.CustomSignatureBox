using ElectronicSignatureDocumentViewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicSignatureDocumentViewer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            SignatureData data = new SignatureData()
            {
                Barcode = "https://www.textcontrol.com/",
                IPAddress = "102.72.278.0",
                Signer = "Tim Typer"
            };

            return View(data);
        }

        public ActionResult Thanks()
        {
            return View();
        }
    }
}