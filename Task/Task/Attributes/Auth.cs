﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task.Attributes
{
    public class Auth : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            if (HttpContext.Current.Session["login"] == null)
            {
                filterContext.Result = new RedirectResult("/Auth/Index");
            }

            base.OnActionExecuting(filterContext);
        }
    }
}