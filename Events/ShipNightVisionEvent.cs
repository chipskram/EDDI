using System;
using Utilities;

namespace EddiEvents
{
    [PublicAPI]
    public class ShipNightVisionEvent ( DateTime timestamp, bool nightvision ) : Event( timestamp, NAME )
    {
        public const string NAME = "Night vision";
        public const string DESCRIPTION = "Triggered when you activate or deactivate your night vision";
        public const string SAMPLE = null;

        [PublicAPI("A boolean value. True if your night vision is on.")]
        public bool nightvision { get; private set; } = nightvision;
    }
}
