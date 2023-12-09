using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SpirinIS.Sprint5.TaskReview.V15.Lib;
using System.IO;

namespace Tyuiu.SpirinIS.Sprint5.TaskReview.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Мартысевич А. Д. | ИИПб-23-3";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема:  SprintReview                                                    *");
            Console.WriteLine("* Задание #TaskReview                                                    *");
            Console.WriteLine("* Вариант #15                                                            *");
            Console.WriteLine("* Выполнил: Мартысевич Андрей Денисович | ИИПб-23-3                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Создать папку в ручную и скопировать в неё файл в котором есть набор   *");
            Console.WriteLine("* символьных данных.Удалить все слова длиной 2 символа.                  *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V15.txt.       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask7V15.txt";
            string pathSave = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V15.txt";
            Console.WriteLine("Данные находятся в файле " + path);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Находится в файле                                                      *");
            pathSave = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSave);
            Console.ReadKey();
        }
    }
}
