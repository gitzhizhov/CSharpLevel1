using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HW8_5
{
    class Convert
    {
        string pathFrom; // файл откуда
        string pathTo; // файл куда
        public List<Student> list;
        private bool resOK = false;
        //StreamReader sr;
        

        public Convert()
        {
            list = new List<Student>();
        }

        public string PathFrom { get => pathFrom; set => pathFrom = value; }
        public string PathTo { get => pathTo; set => pathTo = value; }
        public bool ResOK { get => resOK; set => resOK = value; }

        /// <summary>
        /// Метод считывает из файла, заполняет список студентов
        /// </summary>
        /// <param name="path">Файл</param>
        private void ReadFile(string path)
        {
            foreach (var line in File.ReadLines(path))
            {
                try
                {
                    string[] s = line.Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new Student(s[0], s[1], s[2], s[3], int.Parse(s[4]), s[5], int.Parse(s[6]), s[7], int.Parse(s[8])));
                }
                catch (Exception e)
                {
                    Program.MF.Info("Ошибка в структуре файла");
                }
            }

            //sr = new StreamReader(path);
            //while (!sr.EndOfStream)
            //{
            //    try
            //    {
            //        string[] s = sr.ReadLine().Split(';');
            //        // Добавляем в список новый экземпляр класса Student
            //        list.Add(new Student(s[0], s[1], s[2], s[3], int.Parse(s[4]), s[5], int.Parse(s[6]), s[7], int.Parse(s[8])));
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //        Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
            //        // Выход из Main
            //        if (Console.ReadKey().Key == ConsoleKey.Escape) return;
            //    }
            //}
        }

        /// <summary>
        /// Метод сериализуем данные (записываем xml-файл), сохранения в указынный файл.
        /// </summary>
        /// <param name="path"></param>
        private void SaveFile(string path)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            FileStream file = File.Create(path);
            xmlFormat.Serialize(file, list);
            file.Close();

            //Stream fw = new FileStream(path, FileMode.Create, FileAccess.Write);
            //xmlSerializer.Serialize(fw, list);
            //fw.Close();
        }

        /// <summary>
        /// Метод запуска конвертации
        /// </summary>
        public void Conv()
        {
            ReadFile(pathFrom);
            SaveFile(pathTo);
            resOK = true;
        }
    }
}
