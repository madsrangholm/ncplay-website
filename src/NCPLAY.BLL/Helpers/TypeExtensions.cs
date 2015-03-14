using System;
using System.Diagnostics.Contracts;

namespace NCPLAY.BLL.Helpers
{
    public static class TypeExtensions
    {
        private static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        ///     Convert an epoch time notation to a DateTime object
        /// </summary>
        /// <param name="number">Epoch time notation</param>
        /// <returns>Corresponding DateTime object</returns>
        public static DateTime EpochToDate(this long number)
        {
            Contract.Requires(number >= 0, "number cannot be negative");
            return Epoch.AddSeconds(number);
        }

        public static string ToPascalCase(this string text)
        {
            return text.Substring(0, 1).ToLower() + text.Substring(1, text.Length - 1);
        }
    }
}