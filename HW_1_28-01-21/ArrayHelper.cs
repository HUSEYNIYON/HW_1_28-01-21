using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW_1_28_01_21
{
    static class ArrayHelper
    {
        //Method Pop()
        public static string Pop(ref string[] Arr)
        {
            int IndexRemoteElement = Arr.Length - 1;
            string RemoteElement = Arr[IndexRemoteElement];
            Arr = Arr.Where((item, index) => index != IndexRemoteElement).ToArray();
            return RemoteElement;
        }
        public static int Pop(ref int[] Arr)
        {
            int IndexRemoteElement = Arr.Length - 1;
            int RemoteElement = Arr[IndexRemoteElement];
            Arr = Arr.Where((item, index) => index != IndexRemoteElement).ToArray();
            return RemoteElement;
        }
        public static double Pop(ref double[] Arr)
        {
            int IndexRemoteElement = Arr.Length - 1;
            double RemoteElement = Arr[IndexRemoteElement];
            Arr = Arr.Where((item, index) => index != IndexRemoteElement).ToArray();
            return RemoteElement;
        }
        public static decimal Pop(ref decimal[] Arr)
        {
            int IndexRemoteElement = Arr.Length - 1;
            decimal RemoteElement = Arr[IndexRemoteElement];
            Arr = Arr.Where((item, index) => index != IndexRemoteElement).ToArray();
            return RemoteElement;
        }
        public static float Pop(ref float[] Arr)
        {
            int IndexRemoteElement = Arr.Length - 1;
            float RemoteElement = Arr[IndexRemoteElement];
            Arr = Arr.Where((item, index) => index != IndexRemoteElement).ToArray();
            return RemoteElement;
        }


        //Method Push()
        public static int Push(ref string[] Arr, string Element)
        {
            Arr = Arr.Concat(new string[] { Element }).ToArray();
            int LengthUpdatedArray = Arr.Length;
            return LengthUpdatedArray;
        }
        public static int Push(ref int[] Arr, int Element)
        {
            Arr = Arr.Concat(new int[] { Element }).ToArray();
            int LengthUpdatedArray = Arr.Length;
            return LengthUpdatedArray;
        }
        public static int Push(ref double[] Arr, double Element)
        {
            Arr = Arr.Concat(new double[] { Element }).ToArray();
            int LengthUpdatedArray = Arr.Length;
            return LengthUpdatedArray;
        }
        public static int Push(ref Decimal[] Arr, Decimal Element)
        {
            Arr = Arr.Concat(new Decimal[] { Element }).ToArray();
            int LengthUpdatedArray = Arr.Length;
            return LengthUpdatedArray;
        }
        public static int Push(ref float[] Arr, float Element)
        {
            Arr = Arr.Concat(new float[] { Element }).ToArray();
            int LengthUpdatedArray = Arr.Length;
            return LengthUpdatedArray;
        }


        //Method Shift()
        public static string Shift(ref string[] Arr)
        {
            string RemoteElement = Arr[0];
            Arr = Arr.Where((item, index) => index != 0).ToArray();
            return RemoteElement;
        }
        public static int Shift(ref int[] Arr)
        {
            int RemoteElement = Arr[0];
            Arr = Arr.Where((item, index) => index != 0).ToArray();
            return RemoteElement;
        }
        public static double Shift(ref double[] Arr)
        {
            double RemoteElement = Arr[0];
            Arr = Arr.Where((item, index) => index != 0).ToArray();
            return RemoteElement;
        }
        public static Decimal Shift(ref Decimal[] Arr)
        {
            Decimal RemoteElement = Arr[0];
            Arr = Arr.Where((item, index) => index != 0).ToArray();
            return RemoteElement;
        }
        public static float Shift(ref float[] Arr)
        {
            float RemoteElement = Arr[0];
            Arr = Arr.Where((item, index) => index != 0).ToArray();
            return RemoteElement;
        }


        //Method UnShift()
        public static int UnShift(ref string[] Arr, string Element)
        {
            var NewArray = new string[Arr.Length + 1];
            Array.Copy(Arr, 0, NewArray, 1, Arr.Length);
            int LengthUpdatedArray = NewArray.Length;
            return LengthUpdatedArray;
        }
        public static int UnShift(ref int[] Arr, int Element)
        {
            var NewArray = new int[Arr.Length + 1];
            Array.Copy(Arr, 0, NewArray, 1, Arr.Length);
            int LengthUpdatedArray = NewArray.Length;
            return LengthUpdatedArray;
        }
        public static int UnShift(ref double[] Arr, double Element)
        {
            var NewArray = new double[Arr.Length + 1];
            Array.Copy(Arr, 0, NewArray, 1, Arr.Length);
            int LengthUpdatedArray = NewArray.Length;
            return LengthUpdatedArray;
        }
        public static int UnShift(ref Decimal[] Arr, Decimal Element)
        {
            var NewArray = new Decimal[Arr.Length + 1];
            Array.Copy(Arr, 0, NewArray, 1, Arr.Length);
            int LengthUpdatedArray = NewArray.Length;
            return LengthUpdatedArray;
        }
        public static int UnShift(ref float[] Arr, float Element)
        {
            var NewArray = new float[Arr.Length + 1];
            Array.Copy(Arr, 0, NewArray, 1, Arr.Length);
            int LengthUpdatedArray = NewArray.Length;
            return LengthUpdatedArray;
        }
    }
}
/*Сложности было немного о синтаксисе технологии Linq!
    Решил данную проблему с помощью сайта metanit.com и оффициальной страницы майкрософт!!!*/
