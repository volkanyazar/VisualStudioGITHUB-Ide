using System;

namespace Sube2.InterfacesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDeneme d = new Deneme();
            d.Yazdir();
            d = new Test();
            d.Yazdir();


        }
    }

    class Deneme : IDeneme
    {    
        public void Yazdir()
        {
            Console.WriteLine("Deneme içindeki metod çalıştı");
        }
    }

    interface IDeneme
    { 
        public void Yazdir();
    }


    class Test : IDeneme
    {
        public void Yazdir()
        {
            Console.WriteLine("Test içindeki metod çalıştı");
        }
    }
}
