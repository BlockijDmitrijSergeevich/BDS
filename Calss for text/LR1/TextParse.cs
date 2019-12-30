using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LR1
{
        class TextParse
        {
        public static bool IsSeparator(char temp)
        {
            if (temp == ' ' || temp == '\t' || temp == '\n' || temp == '\r')
                return true;
            return false;
        }

        static bool IsAPunctuationMark(char temp)
        {
            if (temp == ':' || temp == ';' || temp == '"' || temp == '\'' || temp == ',' || temp == '!' || temp == '?' || temp == '.')
            {
                return true;
            }
            return false;
        }

        public static bool EndOfSentence(char temp)
        {
            if (temp == '!' || temp == '?' || temp == '.' || temp == ';')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsCodeSymbols(char temp)
        {
            if (temp == '{' || temp == '}' || temp == ')' || temp == '(' || temp == '[' || temp == ']' || temp == '$' || temp == '=')
            {
                return true;
            }
            return false;
        }

        public static Text Parse(string txt)
        {
            bool newSentence = false;
            Word preWord = new Word();
            Text text = new Text();
            Sentence sentence = new Sentence();
            Word word = new Word();
            for (int i = 0; i < txt.Length; i++)
            {
                if (!IsAPunctuationMark(txt[i]) && !IsSeparator(txt[i]) && !IsCodeSymbols(txt[i]))
                {
                    word.symbals += txt[i];
                }
                else if (IsAPunctuationMark(txt[i]))
                {
                    if (word.symbals == null)
                        word.punctuationMarkBefore = txt[i];
                    else
                        word.punctuationMarkAfter.Add(txt[i]);

                    if (EndOfSentence(txt[i]) && word.symbals != null)
                    {
                        sentence.GetType(txt[i]);
                        newSentence = true;
                    }
                }
                else
                {
                    if (txt[i] == '\r' && word.symbals != null)
                    {
                        word.PresenceOfLineFeed = true;
                        newSentence = true;
                    }
                }
                if ((IsSeparator(txt[i]) || i == (txt.Length - 1) || IsCodeSymbols(txt[i]) || txt[i] == '.') && word.symbals != null)
                {
                    sentence.Add(word);
                    if (newSentence)
                    {
                        text.Add(sentence);
                        sentence = new Sentence();
                    }
                    word = new Word();
                    newSentence = false;
                }
            }
            return text;
        }
    }
}
