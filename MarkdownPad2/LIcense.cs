﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarkdownPad2.Licensing
{
    public class License
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public System.DateTime CreationDate { get; set; }
        public string Product { get; set; }
        public int LicenseTypeId { get; set; }
    }
}
