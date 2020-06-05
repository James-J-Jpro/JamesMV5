using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JamesScioMVC5.Filters
{
    public class ResultFilter : FilterAttribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {

        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {

        }

    }
}