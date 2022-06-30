using Microsoft.AspNetCore.Components;
using System.Text.RegularExpressions;

namespace Portfolio.Client.Components
{
    public partial class StylizedPunctuation
    {
        [Parameter] public string Text { get; set; }

        private List<(string text, bool stylized)> stylizedText = new();

        private static readonly string symbolsGroupName = "symbols";

        private Regex symbolsToStylize = new($"[^.:?]+|(?'{symbolsGroupName}'[.:?]+)", RegexOptions.Compiled);

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            var matches = symbolsToStylize.Matches(Text);
            foreach (Match match in matches)
            {
                var isSymbolMatch = match.Groups.TryGetValue(symbolsGroupName, out var group) && group.Success;
                stylizedText.Add((match.Value, isSymbolMatch));
            }
        }
    }
}
