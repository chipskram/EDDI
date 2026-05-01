using Cottle;
using EddiSpeechResponder.ScriptResolverService;
using EddiDisplayPadService;
using JetBrains.Annotations;
using System;

namespace EddiSpeechResponder.CustomFunctions
{
    [UsedImplicitly]
    public class SetDPButtonIcon : ICustomFunction
    {
        public string name => "SetDPButtonIcon";
        public FunctionCategory Category => FunctionCategory.Utility;
        public string description => Properties.CustomFunctions_Untranslated.SetDPButtonIcon;
        public Type ReturnType => typeof( string );
        public IFunction function => Function.CreateNativeVariadic( ( runtime, input, writer ) =>
        {
            var dpService = new DisplayPadService();
            var id = input[0].AsNumber;
            var path = input[1].AsString;
            var btnId = input[2].AsNumber;

            dpService.SetButtonIcon( (int) id, path, (int) btnId );

            return "";
        });
    }
}
