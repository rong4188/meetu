﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace MeetU.Models
{
    public class ProfileDataUri
    {
        [Required]
        [Key]
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }

        [JsonIgnore]
        public virtual ApplicationUser ApplicationUser { get; set; }

        public string Image { get; set; }

        [Required]
        public string ImageFormat { get; set; }
    }
}