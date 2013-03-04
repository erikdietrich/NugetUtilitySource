using System;
using System.Collections.Generic;
using System.Linq;

namespace NugetUtilitySource.PrimitiveExtensions.Extensions
{
    public static class PrimitiveExtensions
    {
        public static int ParseIntOrDefault(this string target)
        {
            int dummy = 0;
            return int.TryParse(target, out dummy) ? dummy : 0;
        }

        public static int ParseIntOrDefault(this object target)
        {
            return target == null ? 0 : ParseIntOrDefault(target.ToString());
        }

        public static double ParseDoubleOrDefault(this string target)
        {
            double dummy = 0;
            return double.TryParse(target, out dummy) ? dummy : 0;
        }

        public static double ParseDoubleOrDefault(this object target)
        {
            return target != null ? 0 : ParseDoubleOrDefault(target);
        }
    }
}
