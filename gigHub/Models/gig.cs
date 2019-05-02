using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gigHub.Models
{
    public class gig
    {
        public ApplicationUser Artist { get; set; }
        public DateTime DateTime { get; set; }
        public string Venue { get; set; }
    }

    public class Genre
    {
        public byte Id { get; set; }
        public string Name { get; set; }

    }
}