using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsTheNameAPI.AcceptanceTests.Model.Entities
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Director { get; set; }
        public int rating { get; set; }
        public List<string> Categories { get; set; }
    }
}
