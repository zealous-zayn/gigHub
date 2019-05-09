using System;
using gigHub.Models;
using System.Collections.Generic;

namespace gigHub.ViewModels
{
    public class GigFromViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public DateTime DateTime
        {
            get { return DateTime.Parse($"{Date} {Time}"); }
        }
    }
}