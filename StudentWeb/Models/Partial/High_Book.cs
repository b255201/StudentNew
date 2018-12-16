﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudenWeb.Models.Partial
{
    [MetadataType(typeof(High_BookMetadata))]

    public partial class High_Book
    {
        public class High_BookMetadata
        {
            [DisplayName("編號")]
            public int Id { get; set; }
            public string Image { get; set; }
            [DisplayName("產品描述")]
            public string title { get; set; }
            public string Description { get; set; }
        }
    }

}