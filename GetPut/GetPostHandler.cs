using System;
using System.Web;

namespace GetPut
{
    public class GetPostHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            string A = request.Params["x"];
            string B = request.Params["y"];
            int parmA = Convert.ToInt32(A);
            int parmB = Convert.ToInt32(B);
            int result = parmA + parmB;
            response.AddHeader("Content-Type", "text/plain");
            response.Write($"Summ - {result}");
        }
    }
}

