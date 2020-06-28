
using Microsoft.AspNetCore.Mvc;
using Repos.ChatMessagesRepo;
using System.Collections.Generic;


namespace Controllers.ChatMessageController{

    [Route("api/chatbot")]
    [ApiController]
    public class ChatMessageController {

        private readonly ChatMessagesRepo _repo = new ChatMessagesRepo();

        [HttpGet("{message}")]
        public ActionResult<string> getChatMessageResponse(string message){


            return new OkObjectResult(_repo.getMessageFromBot(message));



        }

    }
}