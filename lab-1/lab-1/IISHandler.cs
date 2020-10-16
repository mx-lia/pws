using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.SessionState;

namespace lab_1
{
    public class IISHandler : IHttpHandler, IRequiresSessionState
    {
        /// <summary>
        /// Вам потребуется настроить этот обработчик в файле Web.config вашего 
        /// веб-сайта и зарегистрировать его с помощью IIS, чтобы затем воспользоваться им.
        /// см. на этой странице: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region Члены IHttpHandler

        public bool IsReusable
        {
            // Верните значение false в том случае, если ваш управляемый обработчик не может быть повторно использован для другого запроса.
            // Обычно значение false соответствует случаю, когда некоторые данные о состоянии сохранены по запросу.
            get { return true; }
        }

        public static int Result { get; set; }

        public void ProcessRequest(HttpContext context)
        {
            try
            {
                if (context.Session["numbers"] == null)
                {
                    context.Session["numbers"] = new Stack<int>();
                }

                Stack<int> numbers = (Stack<int>)context.Session["numbers"];

                switch (context.Request.HttpMethod)
                {
                    case "GET":
                        {
                            context.Response.ContentType = "json/text";
                            context.Response.Write(new JavaScriptSerializer().Serialize(new { result = Result, numbers }));
                        }
                        break;
                    case "POST":
                        {
                            Result = int.Parse(context.Request.Params["result"]);
                        }
                        break;
                    case "PUT":
                        {
                            numbers.Push(int.Parse(context.Request.Params["add"]));
                            context.Session["numbers"] = numbers;
                            Result += numbers.FirstOrDefault();
                        }
                        break;
                    case "DELETE":
                        {
                            if (numbers.Count != 0)
                            {
                                numbers.Pop();
                                context.Session["numbers"] = numbers;
                                Result += numbers.FirstOrDefault();
                            }
                        }
                        break;
                    default:
                        {
                            context.Response.StatusCode = 405;
                            context.Response.End();
                        }
                        break;
                }
            }
            catch (Exception e)
            {
                context.Response.StatusCode = 500;
                context.Response.ContentType = "json/text";
                context.Response.Write(new JavaScriptSerializer().Serialize(new { error = e.Message }));
            }

        }

        #endregion
    }
}
