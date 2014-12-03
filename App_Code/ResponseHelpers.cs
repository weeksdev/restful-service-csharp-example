using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeksDev
{
    /// <summary>
    /// Summary description for ResponseHelpers
    /// </summary>
    public static class ResponseHelpers
    {
        public static void WriteJsonResponse(this object data, string message = "", string header = "", bool success = true)
        {
            string callback = HttpContext.Current.Request.Params.Get("callback");
            if (callback == null || callback == "") {
                HttpContext.Current.Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(new { header = header, message = message, data = data, success = success }));
            } else {
                HttpContext.Current.Response.Write(callback + "(" + Newtonsoft.Json.JsonConvert.SerializeObject(new { header = header, message = message, data = data, success = success }) + ")");
            }
        }
    }
}