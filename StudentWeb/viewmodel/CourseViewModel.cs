﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudenWeb.ViewModel
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Course { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}