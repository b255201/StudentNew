﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudenWeb.ViewModel
{
    public class LessonViewModel
    {
        public int Id { get; set; } 
        public string Description { get; set; }
        public string Image { get; set; }

        public string title { get; set; }

        public int SeqID { get; set; }

        public string Memo { get; set; }
    }
}