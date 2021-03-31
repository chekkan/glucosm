using Microsoft.AspNetCore.Mvc;

namespace Glucosm.Web.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View();
    }
}