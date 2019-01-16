using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webTest.DTO
{
    [JsonObject]
    public class MessageDTO
    {
        [JsonProperty]
        public string ShortMessage { get; set; }
        [JsonProperty]
        public string Message { get; set; }
    }
}
