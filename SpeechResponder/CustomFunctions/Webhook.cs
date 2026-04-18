using Cottle;
using EddiSpeechResponder.ScriptResolverService;
using EddiWebhookService;
using JetBrains.Annotations;
using System;

namespace EddiSpeechResponder.CustomFunctions
{
    [UsedImplicitly]
    public class Webhook : ICustomFunction
    {
        public string name => "Webhook";
        public FunctionCategory Category => FunctionCategory.Utility;
        public string description => Properties.CustomFunctions_Untranslated.Webhook;
        public Type ReturnType => typeof( string );
        public IFunction function => Function.CreateNative1( ( runtime, input, writer ) =>
        {
            var webhookService = new WebhookService();
            var url = input.AsString;

            if ( string.IsNullOrEmpty(url)) { return ""; }

            webhookService.SendRequest( url );

            return "";
        });
    }
}
