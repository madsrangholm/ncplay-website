using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

/// <summary>
///     Used to replace a key value combination with tokens in a string
///     Tokens in a string (example):
///     Hi $[nameToken], welcome to the site!
///     Token values to replace (example):
///     {nameToken = someName,someOtherToken = someOtherValue>}
/// </summary>
public class TokenReplacer
{
    private readonly Dictionary<string, string> _placeholders = new Dictionary<string, string>();

    public TokenReplacer()
    {
    }

    public TokenReplacer(params KeyValuePair<string, string>[] tokens)
    {
        foreach (var keyValuePair in tokens)
        {
            _placeholders.Add(keyValuePair.Key, keyValuePair.Value);
        }
    }

    public string Replace(string text)
    {
        //Contract.Requires(text != null, "text cannot be null");
        //Contract.Ensures(//Contract.Result<string>() != null);
        return Regex.Replace(text, @"(\$\[)([^\]]+)(\])", MatchPlaceholders);
    }

    private string MatchPlaceholders(Match m)
    {
        var placeholderName = m.Groups[2].Value;
        var placeholderValue = string.Empty;

        if (!string.IsNullOrEmpty(placeholderName))
        {
            placeholderValue = _placeholders.ContainsKey(placeholderName)
                ? _placeholders[placeholderName]
                : string.Empty;
        }

        return m.Result(placeholderValue);
    }
}