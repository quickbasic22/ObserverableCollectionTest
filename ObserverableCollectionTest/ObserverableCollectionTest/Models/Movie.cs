using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverableCollectionTest.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public DateTime Released { get; set; }
    }
}
