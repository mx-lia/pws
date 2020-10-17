using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace ASMXService
{
    /// <summary>
    /// Сводное описание для Simplex
    /// </summary>
    [ScriptService]
    [WebService(Description = "lab-4", Namespace = "http://MYS/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class Simplex : System.Web.Services.WebService
    {

        [WebMethod(Description = "lab-4: add", MessageName = "add")]
        public int Add(int x, int y)
        {
            return x + y;
        }

        [WebMethod(Description = "lab-4: concat", MessageName = "concat")]
        public string Concat(string s, double d)
        {
            return s + ' ' + d;
        }

        [WebMethod(Description = "lab-4: sum", MessageName = "sum")]
        public A Sum(A a1, A a2)
        {
            Stream stream = this.Context.Request.InputStream;
            stream.Position = 0;
            StreamReader streamReader = new StreamReader(this.Context.Request.InputStream);
            string s = streamReader.ReadToEnd();
            Console.WriteLine(s);
            streamReader.Close();

            return new A { s = a1.s + ' ' + a2.s, k = a1.k + a2.k, f = a1.f + a2.f };
        }

        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        [WebMethod(Description = "lab-4: addS", MessageName = "addS")]
        public string AddS(int x, int y)
        {
            return JsonConvert.SerializeObject(x + y);
        }
    }
}
