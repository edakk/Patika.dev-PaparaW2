using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaparaSecondWeek.Models
{
    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public int Message { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
