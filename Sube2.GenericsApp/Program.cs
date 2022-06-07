using System;
using System.Collections;
using System.Collections.Generic;

namespace Sube2.GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[5];

            ArrayList al = new ArrayList();
            al.Add(1);//Boxing
            al.Add("Ahmet");
            al.Add(true);
            al.Add(false);
            al.Add(2);
            al.Capacity = al.Count;
            Console.WriteLine($"Eleman Sayısı:{al.Count}\nKapasite:{al.Capacity}");

            int sayi = (int)al[0];//Unboxing

            List<int> lst = new List<int>();
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Capacity = lst.Count;


            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(6, "Ankara");

            Hashtable ht = new Hashtable();
            ht.Add(6, "Ankara");
        }

    }


    //Generic constraints
    //Generic Kısıtlayıcıları
    class Deneme<T, U> where T : class
                      where U : struct
    {
        public T veri;
        public U _veri;

        public string Yazdir(T data)
        {
            return data.ToString();
        }
    }

    class Test
    {
        private Test()
        {

        }
        public void Yazdir<T>(T param)
        {
            Console.WriteLine(param);
        }
    }
}
