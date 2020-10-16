using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Script.Serialization;

namespace lab_2.Controllers
{
    public class WebApiController : ApiController
    {
        // GET api/<controller>
        public string Get()
        {
            return JsonConvert.SerializeObject(new { result = (int)HttpContext.Current.Application["result"], numbers = (Stack<int>)HttpContext.Current.Application["numbers"] });
        }

        // POST api/<controller>
        public void Post(int result)
        {
            HttpContext.Current.Application["result"] = result;
        }

        // PUT api/<controller>
        public void Put(int add)
        {
            Stack<int> numbers = (Stack<int>)HttpContext.Current.Application["numbers"];
            numbers.Push(add);
            HttpContext.Current.Application["numbers"] = numbers;
            HttpContext.Current.Application["result"] = (int)HttpContext.Current.Application["result"] + numbers.FirstOrDefault();
        }

        // DELETE api/<controller>
        public void Delete()
        {
            Stack<int> numbers = (Stack<int>)HttpContext.Current.Application["numbers"];
            if (numbers.Count != 0)
            {
                numbers.Pop();
                HttpContext.Current.Application["numbers"] = numbers;
                HttpContext.Current.Application["result"] = (int)HttpContext.Current.Application["result"] + numbers.FirstOrDefault();
            }

        }
    }
}