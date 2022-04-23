using System;
using System.Web;

namespace GetPut
{
    public class IISHandler3 : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }
        public void ProcessRequest(HttpContext context)
        {
            HttpResponse res = context.Response;
            res.Write("Welcome to Put");
        }
    }
}
