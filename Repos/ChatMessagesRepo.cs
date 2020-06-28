using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using RestSharp;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Repos.ChatMessagesRepo {

    public class ChatMessagesRepo {
        private object jsonString;

        public string getMessageFromBot (string message) {
            var client = new RestClient ("https://acobot-brainshop-ai-v1.p.rapidapi.com/get?bid=178&key=sX5A2PcYZbsN5EY6&uid=mashape&msg=" + message);
            var request = new RestRequest (Method.GET);
            request.AddHeader ("x-rapidapi-host", "acobot-brainshop-ai-v1.p.rapidapi.com");
            request.AddHeader ("x-rapidapi-key", "725d271a28mshcd650d01eca02dep10c201jsn2ccca7ca3ee1");
            IRestResponse response = client.Execute (request);

            Console.WriteLine(jsonString);


            return response.Content;

        }

        public string getCurrentTime() {
            return DateTime.Now.ToString();

        }
    }

    
}