using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab_8.Models
{
    public class ResJsonRPC
    {
        public string Id { get; set; }
        public string Jsonrpc { get; set; }
    }

    public class SuccessResJsonRPC : ResJsonRPC
    {
        public int? Result { get; set; }
    }

    public class Error
    {
        public int Code { get; set; }
        public string Message { get; set; }
    }

    public class ErrorResJsonRPC : ResJsonRPC
    {
        public Error Error { get; set; }
    }
}