using System;

namespace Chess_AdvancedSE
{
    public static class Constants
    {
        public struct Color
        {
            public const bool WHITE = true;
            public const bool BLACK = false;

            public static bool Random()
            {
                Random rnd = new();
                return rnd.NextDouble() >= 0.5;
            }
        }
    }
}
