﻿using System;
using System.Collections.Generic;
using System.Text;

namespace jsreport.Types
{
    public class HtmlToXlsx
    {      
        public string HtmlEngine { get; set; }
        public string TemplateAssetShortid { get; set; }
        public Asset TemplateAsset { get; set; }
    }
}
