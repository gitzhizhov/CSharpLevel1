using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_2
{
    //2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    //   а) Вывести только те слова сообщения, которые содержат не более n букв.
    //   б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //   в) Найти самое длинное слово сообщения.
    //   г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    //   д) *** Создать метод, который производит частотный анализ текста.
    //   В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
    //   Здесь требуется использовать класс Dictionary.

    static class Message
    {
        /// <summary>
        /// Переводит текст в массив слов, удаляет знаки припинания.
        /// </summary>
        /// <param name="text">Строку текста</param>
        /// <returns>Массив слов</returns>
        static string[] ReplaceFromArray(string text)
        {
            Char[] rpl = { ' ', ',', '.', '-', '\n', '\t' };
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].TrimEnd(rpl);
            }
            return words;
        }

        /// <summary>
        /// Возвращает список слов в тексте, которые содержат не более n букв 
        /// </summary>
        /// <param name="text">Текст</param>
        /// <param name="n">Колличество букв</param>
        /// <returns>Список слов</returns>
        public static List<string> WordsLength(string text, int n)
        {
            string[] words = ReplaceFromArray(text);
            List<string> newWords = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= n)
                    newWords.Add(words[i]);
            }
            return newWords;
        }

        /// <summary>
        /// Удаляет из текста все слова, которые заканчиваются на заданный символ.
        /// </summary>
        /// <param name="text">Текст</param>
        /// <param name="endChar">Символ</param>
        public static string DelWordCharEnd(string text, char endChar)
        {
            string[] words = ReplaceFromArray(text);
            foreach (var word in words)
            {
                if (word[word.Length - 1] == endChar)
                {
                    text = text.Replace(word, "");
                }
            }

            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words[i][words[i].Length - 1] == endChar)
            //        words[i] = words[i].Remove(0, words[i].Length);
            //    //text = text.Replace(words[i], "");
            //}
            return text;
        }

        /// <summary>
        /// Находит самое длинное слово в тексте.
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Самое длинное слово</returns>
        public static string MaxWord(string text)
        {
            string max = "";
            string[] words = ReplaceFromArray(text);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > max.Length)
                {
                    max = words[i];
                }
            }
            return max;
        }

        /// <summary>
        /// Состоявляет строку из самых длинных слов сообщения.
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Строка</returns>
        public static string GetLongWordString(string text)
        {
            StringBuilder sb = new StringBuilder();
            int max = MaxWord(text).Length;
            string[] words = ReplaceFromArray(text);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == max)
                {
                    sb.Append(words[i] + " ");
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Частотный анализ текста, частота вхождения слов из массива в тексте
        /// </summary>
        /// <param name="words">Список слов</param>
        /// <param name="text">Текст</param>
        /// <returns>Коллекция</returns>
        public static Dictionary<string, int>  FrequencyAnalysisOfText(string[] words, string text)
        {
            Dictionary<string, int> countWords = new Dictionary<string, int>();
            string[] wordsText = ReplaceFromArray(text);
            foreach (string wordText in wordsText)
            {
                foreach (var word in words)
                {
                    if (wordText == word)
                    {
                        if (countWords.ContainsKey(word))
                            countWords[word]++;
                        else
                            countWords.Add(word, 1);
                    }
                }
            }
            return countWords;
        }
    }
}
