using System;
using System.Globalization;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Linq;


public class CultureAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext filterContext)
    {
        HttpCookie langCookie = filterContext.HttpContext.Request.Cookies["lang"];
        string lang = langCookie != null ? langCookie.Value : "ua";

        var cultureInfo = new CultureInfo(lang);
        Thread.CurrentThread.CurrentCulture = cultureInfo;
        Thread.CurrentThread.CurrentUICulture = cultureInfo;
    }
}
