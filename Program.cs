using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = 1;
            int sekondValue = 2;
            Console.WriteLine(" Первое значение = " + firstValue + "\n" + " Второе значение = " + sekondValue);
            int tempValue = firstValue;
            firstValue = sekondValue;
            sekondValue = tempValue;
            Console.WriteLine("\n"+" Переставим значения"+"\n");
            Console.WriteLine(" Первое значение = " + firstValue + "\n" + " Второе значение = " + sekondValue);
            Console.ReadLine();
        }
    }
}
