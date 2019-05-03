using System.Collections;
using System.Collections.Generic;
using gigHub.Models;

namespace gigHub.ViewModels
{
    public class GigFromViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}