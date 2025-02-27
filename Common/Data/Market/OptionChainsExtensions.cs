using System;
using System.Text;
using QuantConnect.Data.Market;

namespace QuantConnect.Data.Market
{
    /// <summary>
    /// Provides extension methods for the <see cref="OptionChains"/> class.
    /// </summary>
    public static class OptionChainsExtensions
    {
        public static string ToPrettyString(this OptionChains chains)
        {
            var sb = new StringBuilder();

            sb.AppendLine("OptionChains:");

            foreach (var kvp in chains)
            {
                sb.AppendLine(kvp.Value.ToPrettyString());
            }

            return sb.ToString();
        }
    }
}