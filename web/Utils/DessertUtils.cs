using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.Utils
{
    public static class DessertUtils
    {
        public const int MaxPoints = 10;
        public enum DessertPoints
        {
            None = 0,
            XSmall = 1,
            Small = 2,
            Medium = 3,
            Large = 5,
            XLarge = 8,
        };
    }
}
