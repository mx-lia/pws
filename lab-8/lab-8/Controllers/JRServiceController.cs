using lab_8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace lab_8.Controllers
{
    public class JRServiceController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Single([FromBody] ReqJsonRPC reqJsonRPC)
        {
            if (HttpContext.Current.Session["errState"] != null && (bool)HttpContext.Current.Session["errState"] == true)
            {
                return Ok(new ErrorResJsonRPC() { Id = reqJsonRPC.Id, Jsonrpc = reqJsonRPC.Jsonrpc, Error = new Error() { Code = -32602, Message = "server error. service is unavailable" } });
            }

            return Ok(GenerateResponse(reqJsonRPC));
        }

        [HttpPost]
        public IHttpActionResult Patch([FromBody] ReqJsonRPC[] reqJsonRPC)
        {
            List<ResJsonRPC> result = new List<ResJsonRPC>();

            for (int i = 0; i < reqJsonRPC.Length; i++)
            {
                if (HttpContext.Current.Session["errState"] != null && (bool)HttpContext.Current.Session["errState"] == true)
                {
                    result.Add(new ErrorResJsonRPC() { Id = reqJsonRPC[i].Id, Jsonrpc = reqJsonRPC[i].Jsonrpc, Error = new Error() { Code = -32602, Message = "server error. service is unavailable" } });
                }
                else
                {
                    result.Add(GenerateResponse(reqJsonRPC[i]));
                }
            }

            return Ok(result.ToArray());
        }

        private ResJsonRPC GenerateResponse(ReqJsonRPC reqJsonRPC)
        {
            try
            {
                int? result = null;
                string key = reqJsonRPC.Params.Key;
                int? value = reqJsonRPC.Params.Value;

                switch (reqJsonRPC.Method)
                {
                    case "SetM":
                        {
                            result = SetM(key, value.Value);
                            break;
                        }
                    case "GetM":
                        {
                            result = GetM(key);
                            break;
                        }
                    case "AddM":
                        {
                            result = AddM(key, value.Value);
                            break;
                        }
                    case "SubM":
                        {
                            result = SubM(key, value.Value);
                            break;
                        }
                    case "MulM":
                        {
                            result = MulM(key, value.Value);
                            break;
                        }
                    case "DivM":
                        {
                            result = DivM(key, value.Value);
                            break;
                        }
                    default:
                        {
                            ErrorExit();
                            return new ErrorResJsonRPC() { Id = reqJsonRPC.Id, Jsonrpc = reqJsonRPC.Jsonrpc, Error = new Error() { Code = -32601, Message = "server error. requested method not found" } };
                        }
                }
                return new SuccessResJsonRPC() { Id = reqJsonRPC.Id, Jsonrpc = reqJsonRPC.Jsonrpc, Result = result };
            }
            catch (Exception ex)
            {
                ErrorExit();
                return new ErrorResJsonRPC() { Id = reqJsonRPC.Id, Jsonrpc = reqJsonRPC.Jsonrpc, Error = new Error() { Code = -32000, Message = ex.Message } };
            }
        }

        private int? GetM(string k)
        {
            object result = HttpContext.Current.Session[k];
            if (result == null)
                return null;
            int.TryParse(result.ToString(), out int x);
            return x;
        }

        private int? SetM(string k, int x)
        {
            HttpContext.Current.Session[k] = x;
            return GetM(k);
        }

        private int? AddM(string k, int x)
        {
            int? value = GetM(k);
            HttpContext.Current.Session[k] = value == null ? x : value + x;
            return GetM(k);
        }

        private int? SubM(string k, int x)
        {
            int? value = GetM(k);
            HttpContext.Current.Session[k] = value == null ? x : value - x;
            return GetM(k);
        }

        private int? DivM(string k, int x)
        {
            int? value = GetM(k);
            HttpContext.Current.Session[k] = value == null ? x : value / x;
            return GetM(k);
        }

        private int? MulM(string k, int x)
        {
            int? value = GetM(k);
            HttpContext.Current.Session[k] = value == null ? x : value * x;
            return GetM(k);
        }

        private void ErrorExit()
        {
            HttpContext.Current.Session.Clear();
            HttpContext.Current.Session["errState"] = true;
        }
    }
}
