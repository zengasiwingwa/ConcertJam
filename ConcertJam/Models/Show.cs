﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConcertJam.Models
{
    public class Show
    {
        public int Id { get; set; }
        public ApplicationUser Artist { get; set; }
        public DateTime DateTime { get; set; }
        public string Venue { get; set; }
        public Genre Genre { get; set; }
    }
}