﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameBrowser.Style
{
    public class StyleRule
    {
        public string Selector { get; set; }
        public Dictionary<string, string> Rules { get; set; }
    }
}
