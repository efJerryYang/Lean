using System;
using System.Text;
using QuantConnect.Data.Market;

namespace QuantConnect.Data.Market {
    /// <summary>
    /// Provides extension methods for the <see cref="OptionChain"/> class.
    /// </summary>
    public static class OptionChainExtensions
    {
        /// <summary>
        /// Converts an OptionChain into a human-readable string representation.
        /// </summary>
        /// <param name="chain">The OptionChain object to format as a string.</param>
        /// <returns>A formatted string containing details of the OptionChain including:
        /// - The Symbol
        /// - Time
        /// - Underlying asset
        /// - Total contracts count
        /// - Filtered contracts count
        /// - List of all contracts
        /// - List of all trade bars
        /// - List of all quote bars
        /// - List of all ticks
        /// </returns>
        public static string ToPrettyString(this OptionChain chain)
        {
            if (chain == null)
            {
                return "OptionChain: null";
            }
            var sb = new StringBuilder();

            sb.AppendLine($"OptionChain for {chain.Symbol}");
            sb.AppendLine($"Time: {chain.Time}");
            sb.AppendLine($"Underlying: {chain.Underlying}");
            sb.AppendLine($"Contracts Count: {chain.Contracts.Count}");
            sb.AppendLine($"Filtered Contracts Count: {chain.FilteredContracts.Count}");

            sb.AppendLine("\nContracts:");
            foreach (var kvp in chain.Contracts)
            {
                sb.AppendLine($"  {kvp.Key}: {kvp.Value}");
            }

            sb.AppendLine("\nTradeBars:");
            foreach (var kvp in chain.TradeBars)
            {
                sb.AppendLine($"  {kvp.Key}: {kvp.Value}");
            }

            sb.AppendLine("\nQuoteBars:");
            foreach (var kvp in chain.QuoteBars)
            {
                sb.AppendLine($"  {kvp.Key}: {kvp.Value}");
            }

            sb.AppendLine("\nTicks:");
            foreach (var kvp in chain.Ticks)
            {
                sb.AppendLine($"  {kvp.Key}: {string.Join(", ", kvp.Value)}");
            }

            return sb.ToString();
        }
    }
}