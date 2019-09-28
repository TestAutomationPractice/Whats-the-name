using RestSharp;
using System.Net;
using TechTalk.SpecFlow;
using WhatsTheNameAPI.AcceptanceTests.Helpers;
using WhatsTheNameAPI.AcceptanceTests.Model.Entities;

namespace WhatsTheNameAPI.AcceptanceTests.Steps
{
    [Binding]
    public class LoginSteps
    {
        private Login _login;
        private IRestResponse _restResponse;
        private HttpStatusCode _statusCode;
        //private LoginResponse _loginResponse;

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
                            .SetResourse("/login/")
                            .AddJsonContent(_login);

            _restResponse = new RestResponse();
            _restResponse = request.Execute();
            _statusCode = _restResponse.StatusCode;
        }
    }
}
