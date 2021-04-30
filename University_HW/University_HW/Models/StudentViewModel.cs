﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace University_HW.Models
{
    public class StudentViewModel
    {
        public string Name { get; set; }
        public string Image_Url { get; set; }
        public string Description { get; set; }
        public List<SelectListItem> Group { get; set; }
        public string DateOfBirth { get; set; }
    }
}