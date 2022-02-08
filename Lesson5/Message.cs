using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Lesson5
{

    //2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    //    а) Вывести только те слова сообщения, которые содержат не более n букв.
    //    б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //    в) Найти самое длинное слово сообщения.
    //    г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    //    д) ***Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и текст, 
    //        в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
    //        Здесь требуется использовать класс Dictionary.
    internal static class Message
    {
        private static readonly string[] separators = new string[]{".", "\t", "\n", "\r\n", ",", " ", "\n", ":", "—", ";", "!", "?", "(", ")"};

        //    а) Вывести только те слова сообщения, которые содержат не более n букв.
        public static void PrintWordsWithLessThanNLetters(string message, int n)
        {
            var words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries); 
            foreach (var word in words)
                if (word.Length <= n)
                    Console.WriteLine(word);
        }

        //    б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        public static string RemoveAllWordsWitnEndCharacter(string message, char character)
        {
            var words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var sb = new StringBuilder();
            foreach (var word in words)
            {
                if(!word.EndsWith(character))
                    sb.Append(word).Append(" ");
            }
            return sb.ToString();
        }

        //  в) Найти самое длинное слово сообщения.
        public static string FindTheLongestWord(string message)
        {
            var words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var res = "";
            foreach (var word in words)
                if(word.Length > res.Length)
                    res = word;
            return res;
        }

        //    г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        public static string LongestWordsOfMessage(string message)
        {
            var words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var sb = new StringBuilder();
            var maxLength = 0;
            foreach (var word in words)
            {
                if(word.Length > maxLength)
                {
                    sb = new StringBuilder(word);
                    maxLength = word.Length;
                }
                else if (word.Length == maxLength)
                    sb.Append(word);
            }

            return sb.ToString();
        }

        //    д) ***Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и текст, 
        //        в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
        //        Здесь требуется использовать класс Dictionary.
        public static Dictionary<string, int> TextFrequencyAnalysis(string[] words, string message)
        {
            var dictionary = new Dictionary<string, int>();
            foreach (var word in words)
                dictionary.Add(word, 0);

            var mesWords = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in mesWords)
                if(dictionary.ContainsKey(word.ToLower()))
                    dictionary[word.ToLower()]++;
            return dictionary;
        }

        //3. Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
        internal static bool IsPermutation(string message1, string message2)
        {
            if (message1.Length != message2.Length)
                return false;

            var dictionary = new Dictionary<char, int>();
            foreach (var letter in message1)
            {
                if (dictionary.ContainsKey(letter))
                    dictionary[letter]++;
                else
                    dictionary[letter] = 1;
            }

            foreach (var letter in message2)
            {
                if (dictionary.ContainsKey(letter))
                {
                    dictionary[letter]--;
                    if(dictionary[letter] < 0)
                        return false;
                }
                else
                    return false;
            }

            if (dictionary.Any(x => x.Value > 0))
                return false;
            return true;
        }
    }
}
