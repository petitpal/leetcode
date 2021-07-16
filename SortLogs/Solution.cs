using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class Solution {
    
    public class Log 
    {
        public string identifier { get; set; }
        public string words { get; set; }
        public bool isLetter { get; set; }
    }
    
    
    public class LogComparer : IComparer<Log>
    {
        public int Compare(Log x, Log y)
        {
            // x to y - -1 = less, 0 = equal, 1 = greater
            if (!x.isLetter)
            {
                // digits are always last
                return -1;
            }
            else
            {
                switch (String.Compare(x.words, y.words))
                {
                    case -1: return -1;
                    case 0: return String.Compare(x.identifier, y.identifier);
                    default: return 1; 
                }
            }
            
        }
    }
    
    public string[] ReorderLogFiles(string[] logs) {
        
        // identifier + contents
        
        // letter logs first
        // - order by content
        // - order by id
        
        // digits
        // - no change of order
        
        
        const string DigitLogRegex = @"([\w\d]+)(\s[0-9]+)+";
        const string LetterLogRegex = @"([\w\d]+)(\s[a-z]+)+";
        
        var orderedLogs = new SortedDictionary<Log, string>(new LogComparer());
        
        foreach (var log in logs) {
        
            var match = Regex.Match(log, LetterLogRegex);
            if (match.Success)
            {
                var logEntry = new Log()
                {
                    identifier = match.Groups[1].Value,
                    words = match.Groups[2].Value,
                    isLetter = true
                };
                orderedLogs.Add(logEntry, log);
            }
            else
            {
                match = Regex.Match(log, DigitLogRegex);
                if (match.Success)
                {
                    var logEntry = new Log()
                    {
                        identifier = match.Groups[1].Value,
                        words = match.Groups[2].Value,
                        isLetter = false
                    };
                    orderedLogs.Add(logEntry, log);
                }
            }
            
        }
        
        return orderedLogs.Values.ToArray();
    }
}