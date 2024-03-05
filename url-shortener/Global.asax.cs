using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;


namespace url_shortener
{
    public class Global : System.Web.HttpApplication
    {
        //void RegisterRoutes(RouteCollection routes)
        //{
        //    routes.MapPageRoute("preview", "{ShortLink}", "~/Redirect.aspx");
        //}
        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //RegisterRoutes(RouteTable.Routes);
        }
    }
}