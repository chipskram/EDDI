using System;
using Utilities;

namespace EddiEvents
{
    [PublicAPI]
    public class ShipHudModeEvent ( DateTime timestamp, bool analysis ) : Event( timestamp, NAME )
    {
        public const string NAME = "HUD Mode";
        public const string DESCRIPTION = "Triggered when you switch the HUD mode between combat and analysis";
        public const string SAMPLE = null;

        [PublicAPI("A boolean value. True if the new mode is analysis.")]
        public bool analysis { get; private set; } = analysis;
    }
}
