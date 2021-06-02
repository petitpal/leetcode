using System.Linq;
using System.Collections.Generic;

public class Solution {

    char[] NormalizedSet = new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

    public IList<string> FindAndReplacePattern(string[] words, string pattern) {
        
        var matches = new List<string>();
        var normalised_pattern = NormalizeString(pattern);

        foreach (var word in words)
        {
            var normalised_word = NormalizeString(word);
            if (normalised_word == normalised_pattern) {
                matches.Add(word);
            }
        }

        return matches;
    }


    // replace each letter in turn with a - z (change on word bounderies)
    public string NormalizeString(string input)
    {
        var chars = input.Distinct();
        var index = 0;

        foreach (var c in chars)
        {
            input = input.Replace(c, NormalizedSet[index]);
            index += 1;
        }

        return input;
    }
}
