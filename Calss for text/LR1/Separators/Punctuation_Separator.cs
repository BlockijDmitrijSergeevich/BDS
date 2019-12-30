using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Separators
{
    public static class Punctuation_Separator
    {
        public static string[] RepeatPunctuationSeparator { get; } = { "\"", "'" };

        public static string[] EndPunctuationSeparator { get; } = { "!", ".", "?", "...", "?!", "!?" };

        public static string[] InnerPunctuationSeparator { get; } = { ",", ";", ":" };

        public static string[] OpenPunctuationSeparator { get; } = { "<", "(", "[", "{", "„", "«", "‘" };

        public static string[] ClosePunctuationSeparator { get; } = { ")", ">", "]", "}", "“", "»", "’" };

        public static string[] AllSentenceSeparators { get; } = {
            ",", ".", "!", "?", "—", "-", "\"", "'", "(", ")",
            "<", ">", ":", ";", "[", "]", "{", "}", "‒", "–", "—",
            "―", "„", "“", "«", "»", "‘", "’", "...", "?!", "!?", "*", "/", "=", "==", "!=", ">=", "=<", "+"
        };

        public static string[] OperationPunctuationSeparator { get; } = { "*", "/", "+", "=", "==", "!=", ">=", "=<" };
    }
}