using System.Web.Mvc;
using UI.ServiceReference1;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var client = new ServiceClient();
            client.Add(new Company {Id = 5, Name = "ABC Company", Address = "1234 Main Street"});

            return View();
        }
    }
}