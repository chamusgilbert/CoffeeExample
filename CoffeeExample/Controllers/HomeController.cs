using Lab20.Models;
using System.Web.Mvc;

namespace Lab20.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Register r)
        {

            ViewBag.Message = "Welcome to the Grand Circus Coffee App";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us.";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Register with Grand Circus Coffee!";
            return View();
        }

        public ActionResult Success(Register r)
        {

            ViewBag.Message = "Welcome " + r.FirstName;
            Session["Email"] = r.Email;
            Session["Name"] = r.FirstName + " " + r.LastName;
            Session["Phone"] = r.Phone;
            return View(r);
        }        //public ActionResult Cookie()
        //{
        //    HttpCookie myCookie = new HttpCookie("User");
        //    myCookie["Name"] = "Sebastian";
        //    myCookie["Color"] = "Blue";
        //    myCookie.Expires{ 1; 2; };
        //    Response.Cookies.Add(myCookie);
        //    return View();

        //    //if (Request.Cookies["User"] != null)
        //}

    }
}
