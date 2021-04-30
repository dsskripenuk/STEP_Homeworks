﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Practice_8.Entity
{
    [Table("tblGroups")]
    public class Group_ST
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
    }
}