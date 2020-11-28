using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab_8.Models
{
    public class KeyValue
    {
        public string Key { get; set; }
        public int? Value { get; set; }
    }

    public class ReqJsonRPC
    {
        public string Id { get; set; }
        public string Jsonrpc { get; set; }
        public string Method { get; set; }
        public KeyValue Params { get; set; }
    }
}