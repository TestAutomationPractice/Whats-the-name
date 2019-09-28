using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsTheNameAPI.AcceptanceTests.Model.Entities
{
    public class LoginResponse
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string street { get; set; }
        public string number { get; set; }

        public List<Movie> myMovies { get; set; }
    }
}
