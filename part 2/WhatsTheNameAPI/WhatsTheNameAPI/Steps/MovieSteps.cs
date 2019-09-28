using System;
using TechTalk.SpecFlow;
using RestSharp;
using WhatsTheNameAPI.AcceptanceTests.Helpers;
using WhatsTheNameAPI.AcceptanceTests.Model.Entities;
using System.Net;
using System.Linq;
using NUnit.Framework;

namespace WhatsTheNameAPI.Steps
{
    [Binding]
    public class MovieSteps
    {
        private Login _login;
        private Movie _movie;
        private IRestResponse _restResponse;
        private HttpStatusCode _statusCode;

        [Given(@"I logged in as (.*) (.*)")]
        public void GivenILoggedInAs(string p0, string p1)
        {
            _login = new Login()
            {
                Username = p0,
                Password = p1
            };

            var request = new HttpRequestWrapper()
                            .SetMethod(Method.POST)
                            .SetResourse("/login/")
                            .AddJsonContent(_login);

            _restResponse = new RestResponse();
            _restResponse = request.Execute();
            _statusCode = _restResponse.StatusCode;
            Assert.Equals(200, _statusCode);
        }

        
        
        [When(@"I add a movie (.*) (.*) (.*) (.*) (.*) (.*)")]
        public void WhenIAddAMovie(string p0, string p1, string p2, string p3, string p4, string p5)
        {
            _movie = new Movie()
            {
                Title = p0,
                Description = p1,
                Image = p2,
                Director = p3,
                Rating = Convert.ToInt32(p4),
                Categories = p5.Split(',').ToList()
            };

            var request = new HttpRequestWrapper()
                            .SetMethod(Method.POST)
                            .SetResourse("/movie/")
                            .AddJsonContent(_movie);

            _restResponse = new RestResponse();
            _restResponse = request.Execute();
            _statusCode = _restResponse.StatusCode;
            Assert.Equals(200, _statusCode);
        }
    }
}
