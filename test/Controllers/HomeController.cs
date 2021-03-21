using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        E_Project_2Entities db = new E_Project_2Entities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult Answers()
        {
            return View();
        }

        public ActionResult ap_evaluate()
        {
            return View();
        }

        public ActionResult app_document()
        {
            return View();
        }

        public ActionResult app_status()
        {
            return View();
        }

        public ActionResult app_test()
        {
            return View();
        }

        public ActionResult applicant()
        {
            return View();
        }

        public ActionResult application()
        {
            return View();
        }

        public ActionResult aps_change()
        {
            return View();
        }

        public ActionResult document()
        {
            return View();
        }

        public ActionResult interview()
        {
            return View();
        }

        public ActionResult interview_note()
        {
            return View();
        }

        public ActionResult job()
        {
            return View();
        }

        public ActionResult job_category()
        {
            return View();
        }

        public ActionResult job_department()
        {
            return View();
        }

        public ActionResult job_orgy()
        {
            return View();
        }

        public ActionResult process()
        {
            return View();
        }

        public ActionResult process_step()
        {
            return View();
        }

        public ActionResult Recruiter()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Step()
        {
            return View();
        }
        public ActionResult tbl_order()
        {
            return View();
        }
        public ActionResult tbl_product()
        {
            return View();
        }

        public ActionResult tbl_user()
        {
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }

    }
}