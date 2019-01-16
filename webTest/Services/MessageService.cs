using PushoverClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webTest.DTO;

namespace webTest.Services
{
    public class MessageService
    {
        private static readonly string API_KEY = "akpk9rcyc22zpt6h5k43bagk4jj2k6";
        private static readonly string USER_KEY = "ucc4or6h4bgfpvogxakmn14gh1wcj5";
        public PushResponse sendPush(MessageDTO message)
        {
            Pushover pushClient = new Pushover(API_KEY);
            return pushClient.Push(message.ShortMessage, message.Message, USER_KEY);
        }
    }
}
