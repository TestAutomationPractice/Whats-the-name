using RestSharp;
using System;
using System.Linq;
using System.Net;
using TechTalk.SpecFlow;
using WhatsTheNameAPI.AcceptanceTests.Helpers;
using WhatsTheNameAPI.AcceptanceTests.Model.Entities;

namespace WhatsTheNameAPI.AcceptanceTests.Steps
{
    [Binding]
    public class MovieSteps
    {
        private Movie _movie;
        private IRestResponse _restResponse;
        private HttpStatusCode _statusCode;
        //private LoginResponse _loginResponse;

        [Then(@"I add a movie \((.*),(.*),(.*),(.*),(.*),(.*)\)")]
        public void GivenIAddMovie(string titel, string description, string image, string director, string rating, string categories)
        {
            _movie = new Movie()
            {
                Title = titel,
                Description = description,
                Image = image,
                Director = director,
                Rating = Convert.ToInt32(rating),
                Categories = categories.Split(',').ToList()
            };

            var request = new HttpRequestWrapper()
                            .SetMethod(Method.POST)
                            .SetResourse("/movie/")
                            .AddJsonContent(_movie);

            _restResponse = new RestResponse();
            _restResponse = request.Execute();
            _statusCode = _restResponse.StatusCode;
            //_loginResponse=JsonConvert.DeserializeObject<LoginResponse>(_restResponse.Content);
            //ScenarioContext.Current.Add("Login", _login);
        }
    }
}
