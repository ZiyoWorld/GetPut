using System;
using System.IO;
using System.Web;

namespace GetPut
{
    public class IISHandler1 : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            string textFormFile = File.ReadAllText("C:/БГТУ/Программа_в_Интернеты/сампрог/GetPut/GetPut/HtmlPage1.html");
            if (context.Request.HttpMethod == "GET")
            {
                context.Response.ContentType = "text/html";
                context.Response.Write(textFormFile);
            }


            if (context.Request.HttpMethod == "POST")
            {
                int parmA = Int32.Parse(context.Request.Form["x"]);
                int parmB = Int32.Parse(context.Request.Form["y"]);

                int mul = parmA * parmB;
                context.Response.Write(String.Format("x={0}, y={1}\n x*y = {2}", parmA, parmB, mul));
                //   HttpResponse res = context.Response;
                //   res.Write("hello");
            }
            HttpResponse res = context.Response;
            res.Write("hello");
        }
    }
}
