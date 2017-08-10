using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Microsoft.Bot.Connector;
using Newtonsoft.Json;

namespace FBPlayersNumber
{
    [BotAuthentication]
    public class MessagesController : ApiController
    {
        public async Task<HttpResponseMessage> Post([FromBody]Activity activity)
        {
            if (activity.Type == ActivityTypes.Message)
            {
                ConnectorClient connector = new ConnectorClient(new Uri(activity.ServiceUrl));               
                Player cm = new Player();

                if (activity.Text.All(char.IsDigit))
                {
                    string PlayerName = cm.getPlayerName(Convert.ToInt32(activity.Text));
                    if (Convert.ToInt32(activity.Text)>99||Convert.ToInt32(activity.Text)<1)
                    {
                        Activity reply = activity.CreateReply($"Lütfen 1 ile 99 arası sayılar giriniz.");
                        await connector.Conversations.ReplyToActivityAsync(reply);
                    }
                    else if (PlayerName == "Kayitli Oyuncu yok")
                    {
                        Activity reply = activity.CreateReply($"Sorguladığınız {activity.Text} forma numarasına sahip oyuncu bulunamadı.");
                        await connector.Conversations.ReplyToActivityAsync(reply);
                    }
                    else
                    {
                        Activity reply = activity.CreateReply($"Sorguladığınız {activity.Text} forma numarası {PlayerName} oyuncusuna aittir.");
                        await connector.Conversations.ReplyToActivityAsync(reply);
                    }
                }
                else
                {
                    int pNumber = cm.getPlayerNumber(activity.Text);

                    Activity reply = activity.CreateReply($"Sorguladığınız {activity.Text} adlı oyuncunun forma numarası: {pNumber}");
                    await connector.Conversations.ReplyToActivityAsync(reply);
                }


            }
            else
            {
                HandleSystemMessage(activity);
            }
            var response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        private Activity HandleSystemMessage(Activity message)
        {
            if (message.Type == ActivityTypes.DeleteUserData)
            {
                // Implement user deletion here
                // If we handle user deletion, return a real message
            }
            else if (message.Type == ActivityTypes.ConversationUpdate)
            {
                // Handle conversation state changes, like members being added and removed
                // Use Activity.MembersAdded and Activity.MembersRemoved and Activity.Action for info
                // Not available in all channels
                
            }
            else if (message.Type == ActivityTypes.ContactRelationUpdate)
            {
                // Handle add/remove from contact lists
                // Activity.From + Activity.Action represent what happened
            }
            else if (message.Type == ActivityTypes.Typing)
            {
                // Handle knowing tha the user is typing
            }
            else if (message.Type == ActivityTypes.Ping)
            {
            }

            return null;
        }
    }
}