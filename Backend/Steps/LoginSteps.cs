using Newtonsoft.Json;
using NUnit.Framework;
using WhatsTheNameAPI.AcceptanceTests.Helpers;
using WhatsTheNameAPI.AcceptanceTests.Model.Entities;
using RestSharp;
using System.Collections.Generic;
using System.Net;
using TechTalk.SpecFlow;
using System.Linq;
using PropertiesAPI.AcceptanceTests.Model.Entities;

namespace WhatsTheNameAPI.AcceptanceTests.Steps
{
    public class LoginSteps
    {
        private Login _login;
        private IRestResponse _restResponse;
        private HttpStatusCode _statusCode;
        private LoginResponse _loginResponse;

        [Given(@"I logged in as \((.*),(.*)\)")]
        public void GivenILogedInAs(string username, string password)
        {
            _login = new Login()
            {
                Username= username,
                Password=password
            };

            var request = new HttpRequestWrapper()
                            .SetMethod(Method.POST)
                            .SetResourse("/api/properties/")
                            .AddJsonContent(_login);

            _restResponse = new RestResponse();
            _restResponse = request.Execute();
            _statusCode = _restResponse.StatusCode;
            _loginResponse=JsonConvert.DeserializeObject<LoginResponse>(_restResponse.Content);
            ScenarioContext.Current.Add("Login", _login);
        }
    }
}
