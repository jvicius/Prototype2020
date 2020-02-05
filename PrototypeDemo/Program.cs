using System;
using PrototypeDemo.Models;

namespace PrototypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var text1 = new Text();
            text1.Texto = "Hello!!!";
            text1.ChangeFont(FontType.Bold);
            text1.Color.R = 50;

            var text2 = (Text) text1.Clone();
            
            text1.TextInfo();
            text2.TextInfo();

            text1.Color.R = 100;

            text1.TextInfo();
            text2.TextInfo();


            Console.ReadKey();
        }
    }
}
