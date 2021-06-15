using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicSignatureDocumentViewer.Controllers
{
    public class SignController : Controller
    {
        [HttpPost]
        public string ExportPDF(string document)
        {
            byte[] bPDF;

            // create temporary ServerTextControl
            using (TXTextControl.ServerTextControl tx = new TXTextControl.ServerTextControl())
            {
                tx.Create();

                // load the document
                tx.Load(Convert.FromBase64String(document), TXTextControl.BinaryStreamType.InternalUnicodeFormat);

                TXTextControl.SaveSettings saveSettings = new TXTextControl.SaveSettings()
                {
                    CreatorApplication = "TX Text Control Sample Application",
                };

                // save the document as PDF
                tx.Save(out bPDF, TXTextControl.BinaryStreamType.AdobePDF, saveSettings);
            }

            // return as Base64 encoded string
            return Convert.ToBase64String(bPDF);
        }
    }
}