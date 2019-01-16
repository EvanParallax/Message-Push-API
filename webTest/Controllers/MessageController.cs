using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PushoverClient;
using webTest.DTO;
using webTest.Services;

namespace webTest.Controllers
{
    [Route("api/message")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        [HttpPost]
        public PushResponse ReceiveMessage([FromBody] MessageDTO message)
        {
            MessageService messageService = new MessageService();
            return messageService.sendPush(message);
        }
    }
}