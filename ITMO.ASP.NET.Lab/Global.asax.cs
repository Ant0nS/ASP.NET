﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ITMO.ASP.NET.Lab
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }
        protected void Application_OnEndRequest() 
        { 
            Response.Write("<hr />Эта страница была загружена " + DateTime.Now.ToString()); 
        }
    }
}