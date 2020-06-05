using System;
using System.Collections.Generic;

using System.Web.Mvc;
using System.Web.Security;

namespace JamesScioMVC5.Filters
{
    public class AuthAttribute : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Request.IsAuthenticated)

            {

                if (!Roles.IsUserInRole("Admin"))

                {

                    ViewResult result = new ViewResult();

                    result.ViewName = "Error";

                    result.ViewBag.ErrorMessage = "Invalid User";

                    filterContext.Result = result;
                }
            }
        }
    }
}