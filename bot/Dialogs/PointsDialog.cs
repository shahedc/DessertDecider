using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using bot.Utils;

namespace bot.Dialogs
{
    [Serializable]
    public class PointsDialog : IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;

            // temp logic
            var textToReturn = string.Empty;
            var textToSearch = activity.Text.ToLower();

            if (textToSearch.Contains("should i eat"))
            {
                var decision = ApiCaller.GetBoolDecision();
                if (decision == true)
                    textToReturn = "Yes!";
                else
                    textToReturn = "No.";
            }
            else if (textToSearch.Contains("points"))
            { 
                textToReturn = ApiCaller.GetNumericPoints().ToString();
            }
            else if (textToSearch.Contains("max"))
            {
                textToReturn = ApiCaller.GetMaxPoints().ToString();
            }

            // return our reply to the user
            await context.PostAsync(textToReturn);

            context.Wait(MessageReceivedAsync);
        }
    }
}