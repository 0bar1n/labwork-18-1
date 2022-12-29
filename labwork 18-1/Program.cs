using System;

namespace labwork_18_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k; //переменная целого типа
            double s = 0;//переменная вещественного типа
            double fact = 1; //переменная вещественного типа
            Console.WriteLine("Введите количество элементов последовательности"); //вывод на консоль
            k = Convert.ToInt32(Console.ReadLine());//ввод и задание переменной
            for (int i = 1; i <= k; i++) //цикл, пока выполняется условие
            {
                fact = fact * i; //факториал
                s += 1 / fact; //сумма n элементов последовательности
            }
            Console.WriteLine(s); //вывод результата
            Console.ReadLine(); //программа ожидает нажатия клавиши для завершения работы
        }
    }
}
