﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalizerBusinessDemo.Models
{
    public class UserContext
    {
        public string WeekDay { get; set; }

        public bool UseUserAgent { get; set; }

        public bool UseTextAnalytics { get; set; }

        public string Profile { get; set; }

        public string Tournament { get; set; }
    }
}


