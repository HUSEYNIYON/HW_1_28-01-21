using System;

namespace HW_1_28_01_21
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ArrayString = { "1", "2", "3", "4", "5", "6" };
            int[] ArrayInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] ArrayDouble = { 1.1, 1.2, 1.3, 1.4, 1.5, 1.6, 1.7, 1.8, 1.9 };
            decimal[] ArrayDecimal = { 1.2m, 1.3m, 1.4m, 1.5m, 1.6m, 1.7m, 1.8m };
            float[] ArrayFloat = { 1.3f, 1.4f, 1.5f, 1.6f, 1.7f, 1.8f, 1.9f, 1.10f, 1.11f };

            //Console.WriteLine($"Удаленный элемент из массива ArrayString: {ArrayHelper.Pop(ref ArrayString)}");
            //Console.WriteLine($"Удаленный элемент из массива ArrayInt: {ArrayHelper.Pop(ref ArrayInt)}");
            //Console.WriteLine($"Удаленный элемент из массива ArrayDouble: {ArrayHelper.Pop(ref ArrayDouble)}");
            //Console.WriteLine($"Удаленный элемент из массива ArrayDecimal: {ArrayHelper.Pop(ref ArrayDecimal)}");
            //Console.WriteLine($"Удаленный элемент из массива ArrayFloat: {ArrayHelper.Pop(ref ArrayFloat)}\n\n");

            Console.WriteLine($"Длина массив ArrayString после добавления еще один элемент с конца массива: {ArrayHelper.Push(ref ArrayString, "7")}");
            Console.WriteLine($"Длина массив ArrayInt после добавления еще один элемент с конца массива: {ArrayHelper.Push(ref ArrayInt, 11)}");
            Console.WriteLine($"Длина массив ArrayDouble после добавления еще один элемент с конца массива: {ArrayHelper.Push(ref ArrayDouble, 6.0)}");
            Console.WriteLine($"Длина массив ArrayDecimal после добавления еще один элемент с конца массива: {ArrayHelper.Push(ref ArrayDecimal, 2.8m)}");
            Console.WriteLine($"Длина массив ArrayFloat после добавления еще один элемент с конца массива: {ArrayHelper.Push(ref ArrayFloat, 7.0f)}\n\n");

            //Console.WriteLine($"Удаленный элемент из массива ArrayString: {ArrayHelper.Shift(ref ArrayString)}");
            //Console.WriteLine($"Удаленный элемент из массива ArrayInt: {ArrayHelper.Shift(ref ArrayInt)}");
            //Console.WriteLine($"Удаленный элемент из массива ArrayDouble: {ArrayHelper.Shift(ref ArrayDouble)}");
            //Console.WriteLine($"Удаленный элемент из массива ArrayDecimal: {ArrayHelper.Shift(ref ArrayDecimal)}");
            //Console.WriteLine($"Удаленный элемент из массива ArrayFloat: {ArrayHelper.Shift(ref ArrayFloat)}\n\n");

            Console.WriteLine($"Длина массив ArrayString после добавления еще один элемент в начало массива: {ArrayHelper.UnShift(ref ArrayString, "0")}");
            Console.WriteLine($"Длина массив ArrayInt после добавления еще один элемент начало массива: {ArrayHelper.UnShift(ref ArrayInt, 0)}");
            Console.WriteLine($"Длина массив ArrayDouble после добавления еще один элемент начало массива: {ArrayHelper.UnShift(ref ArrayDouble, 5.0)}");
            Console.WriteLine($"Длина массив ArrayDecimal после добавления еще один элемент начало массива: {ArrayHelper.UnShift(ref ArrayDecimal, 2.0m)}");
            Console.WriteLine($"Длина массив ArrayFloat после добавления еще один элемент начало массива: {ArrayHelper.UnShift(ref ArrayFloat, 6.0f)}\n");
        }
    }
}
