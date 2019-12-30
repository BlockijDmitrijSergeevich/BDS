using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //string pBook = "ProgrammingBook.txt";
                string txt = IOF.ReadPBook(Properties.Resource.pBook);
                Text text = TextParse.Parse(txt);
                text.DeleteEmptySentences();                
                StreamWriter writeToAnswerTXT = new StreamWriter(Properties.Resource.AnswerBook);

                var cultures = Language.GetAvailableCultures();
                var languages = Language.GetAvailableLanguages(cultures);
                var index = IOC.LanguageMenu(languages);
                Language.SetCurrent(cultures[index]);

                int i, numberMessage = 0;
                do
                {
                    IOC.Write(Properties.Resource.Menu);
                    IOC.Write(Properties.Resource.Les1);
                    IOC.Write(Properties.Resource.Les2);
                    IOC.Write(Properties.Resource.Les3);
                    IOC.Write(Properties.Resource.Les4);
                    IOC.Write(Properties.Resource.Les5);
                    IOC.Write(Properties.Resource.Les0);
                    i = IOC.Answer();
                    switch (i)
                    {
                        case 1:
                            text.SortedByWordCount();
                            text.Output(writeToAnswerTXT, false);
                            break;
                        case 2:
                            int len;
                            string s;

                            IOC.Write(Properties.Resource.String);
                            s = Console.ReadLine();
                            len = Convert.ToInt32(s);
                            text.PrintWordsInInterrogativeSentWithoutRepetitions(writeToAnswerTXT, len);
                            break;
                        case 3:

                            IOC.Write(Properties.Resource.StringWords);
                            s = Console.ReadLine();
                            len = Convert.ToInt32(s);
                            text.WordsDeleteBegWithAConsonant(len);
                            text.DeleteEmptySentences();
                            text.Output(writeToAnswerTXT, true);
                            break;
                        case 4:

                            int numOfSentences;
                            IOC.WriteMessage("Введите предложение (от 1 до " + text.Length + "):");
                            s = Console.ReadLine();
                            numOfSentences = Convert.ToInt32(s);
                            IOC.Write(Properties.Resource.String);
                            s = Console.ReadLine();
                            len = Convert.ToInt32(s);
                            IOC.Write(Properties.Resource.Substring);
                            s = Console.ReadLine();
                            text.WordsReplaceWithSubstring(numOfSentences, len, s);
                            text.Output(writeToAnswerTXT, true);
                            break;
                        case 5:
                            int numOFLines;
                            IOC.Write(Properties.Resource.SentencePage);
                            s = Console.ReadLine();
                            numOFLines = Convert.ToInt32(s);
                            StreamWriter writeToConcordanceTXT = new StreamWriter(Properties.Resource.ConcordanceBook);
                            text.Concordance(writeToConcordanceTXT, numOFLines);
                            writeToConcordanceTXT.Close();
                            break;
                        case 0:                           
                            IOC.Write(Properties.Resource.Exit);
                            break;
                        default:
                            IOC.Write(Properties.Resource.InputError);
                            break;
                    }
                    IOC.WriteMessage("\n\n\t\t\tНажмите любую клавишу...");
                    Console.ReadLine();
                    Console.Clear();
                } while (i != 0);
                writeToAnswerTXT.Close();
            }
            catch(FileNotFoundException ex)
            {
                IOC.Write(Properties.Resource.Error);
                IOC.WriteMessage($"{ex.Message}");
            }
            catch(ArgumentOutOfRangeException ex)
            {
                IOC.Write(Properties.Resource.Error);
                IOC.WriteMessage($"{ex.Message}");
            }
            catch (OutOfMemoryException ex)
            {
                IOC.Write(Properties.Resource.Error);
                IOC.WriteMessage($"{ex.Message}");
            }
            catch (Exception ex)
            {
                IOC.Write(Properties.Resource.Error);
                IOC.WriteMessage($"{ex.Message}");
            }

        }
    }
}
