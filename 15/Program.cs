using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{

//    Разработать интерфейс ISeries генерации ряда чисел.Интерфейс содержит следующие элементы:

//метод void SetStart(int x) - устанавливает начальное значение
//метод int GetNext() - возвращает следующее число ряда
//метод void Reset() - выполняет сброс к начальному значению
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression progression = new ArithProgression();
            progression.SetStart(15);
            progression.SetStep(100);
            Console.WriteLine("Арифметическая прогрессия");
            Console.WriteLine("2 эл-т: {0}", progression.GetNext());
            Console.WriteLine("3 эл-т: {0}", progression.GetNext());
            progression.Reset();
            Console.WriteLine("Сбросили");
            Console.WriteLine("2 эл-т: {0}", progression.GetNext());
            Console.WriteLine("3 эл-т: {0}", progression.GetNext());
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Геометрическая прогрессия");
            GeomProgression geomProgression = new GeomProgression();
            geomProgression.SetStart(1);
            geomProgression.SetStep(5);
            Console.WriteLine("2 эл-т: {0}", geomProgression.GetNext());
            Console.WriteLine("3 эл-т: {0}", geomProgression.GetNext());
            Console.WriteLine("4 эл-т: {0}", geomProgression.GetNext());
            geomProgression.Reset();
            Console.WriteLine("Сбросили");
            Console.WriteLine("2 эл-т: {0}", geomProgression.GetNext());
            Console.WriteLine("3 эл-т: {0}", geomProgression.GetNext());
            Console.ReadKey();
        }
    }
}
