using Newtonsoft.Json;
using System;
using System.IO;
using System.Xml.Serialization;
using WebServices.Simplex;

namespace TestWebFormApp.ASMX_Server
{
    public class SimplexImpl : Simplex
    {
        [return: XmlElement("addResult")]
        public override int Add(int x, int y)
        {
            return x + y;
        }

        [return: XmlElement("concatResult")]
        public override string Concat(string s, double d)
        {
            return s + ' ' + d;
        }

        [return: XmlElement("sumResult")]
        public override A Sum(A a1, A a2)
        {
            Stream stream = this.Context.Request.InputStream;
            stream.Position = 0;
            StreamReader streamReader = new StreamReader(this.Context.Request.InputStream);
            string s = streamReader.ReadToEnd();
            Console.WriteLine(s);
            streamReader.Close();

            return new A { s = a1.s + ' ' + a2.s, k = a1.k + a2.k, f = a1.f + a2.f };
        }

        [return: XmlElement("addSResult")]
        public override string AddS(int x, int y)
        {
            return JsonConvert.SerializeObject(x + y);
        }
    }
}