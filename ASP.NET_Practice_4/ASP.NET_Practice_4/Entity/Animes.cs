﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP.NET_Practice_4.Entity
{
    [Table("tblAnimes")]
    public class Animes
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string DateOfRelease { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public string URL_Image { get; set; }
    }
}