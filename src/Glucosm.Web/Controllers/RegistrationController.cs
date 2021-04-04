using Glucosm.Web.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Glucosm.Web.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ILogger<RegistrationController> _logger;

        public RegistrationController(ILogger<RegistrationController> logger) => _logger = logger;

        [Route("/register"), HttpGet]
        public ViewResult Index() => View();

        [Route("/register", Name = "register"), HttpPost]
        public ViewResult Index(RegistrationModel model)
        {
            _logger.LogInformation("Registering a new user");
            return View();
        }
    }
}