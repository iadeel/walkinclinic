using System.Web.Mvc;

namespace WalkInMedicalClinic.WebUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CardiologyClinic()
        {
            return View();
        }

        public ActionResult WomenHealthClinic()
        {
            return View();
        }

        public ActionResult ClinicResearchAndTrials()
        {
            return View();
        }

        public ActionResult Careers()
        {
            return View();
        }

        public ActionResult ReferralForm()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }
    }
}