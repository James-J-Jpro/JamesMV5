using JamesScioMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JamesScioMVC5.Controllers
{
    [RoutePrefix("myuser")]
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var user = new UserViewModel { ID = 111, Name = "MyTestName111" };
            return View(user);
        }

        [HttpGet]
        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CreateUser(int ID)
        {
            var result = new OperationResult
            {
                statusCode = 400,
                responseMessage = "Not implemented"
            };
            return Json(result);
        }

        public ActionResult GetUser(int ID)
        {
            return View();
        }

        [Route("getbyId/{userID=0}")]
        public JsonResult GetUserName(int userID)
        {
            var user = new UserViewModel { ID = userID, Name = "MyTestName" };
            return Json(user);
        }
    }

    public class OperationResult
    {
        public int statusCode { get; set; }
        public string responseMessage { get; set; }
    }
}