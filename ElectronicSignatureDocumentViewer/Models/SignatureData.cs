using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicSignatureDocumentViewer.Models
{
    public class SignatureData
    {
        public string Barcode { get; set; }
        public string Signer { get; set; }
        public string IPAddress { get; set; }
    }
}