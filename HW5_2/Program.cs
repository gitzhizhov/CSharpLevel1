using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_2
{
    //2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    //   а) Вывести только те слова сообщения,  которые содержат не более n букв.
    //   б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //   в) Найти самое длинное слово сообщения.
    //   г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    //   д) *** Создать метод, который производит частотный анализ текста.
    //   В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
    //   Здесь требуется использовать класс Dictionary.

    // Андрей Жижов

    class Program
    {
        static void Main(string[] args)
        {
            string text = @"Нафаня. Безобидное детское прозвище ставшее его именем в страшном мире, основным населением которого являются монстры. Да такие, каких не в каждом ужастике увидишь. Нафаня, домовой из детского мультика. Так и Афанасию пришлось стать домовым, благо сверхспособности даруемые этим новым миром позволяли вольготно чувствовать себя именно в городах, скрываясь в них от упырей и не только. Для одних он был хорошим домовым, помогая при случае, для других же";

            // а
            List<string> words = Message.WordsLength(text, 5);
            foreach (var item in words)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            // б
            char endWord = 'м';
            text = Message.DelWordCharEnd(text, endWord);
            foreach (var item in text)
            {
                Console.Write($"{item}");
            }

            Console.WriteLine();
            // в
            string maxWord = Message.MaxWord(text);
            Console.WriteLine($"Самое длинное слово: {maxWord}");

            Console.WriteLine();
            // г
            string stringMaxWord = Message.GetLongWordString(text);
            Console.WriteLine($"Строка из длинных слово: {stringMaxWord}");

            Console.WriteLine();
            // д
            string[] word = {"из", "Нафаня", "домовым" };
            Dictionary<string, int> analisis = Message.FrequencyAnalysisOfText(word, text);
            foreach (KeyValuePair<string, int> keyValue in analisis)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            Console.ReadKey();
        }
    }
}
