using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowingHidingPeac
{
    internal class Program
    {
        class Parent
        {
            public int varoable = 273;
        }

        class Child : Parent 
        {
            public new string varoable = "shadowing";
        }
        public static int number = 10;
        static void Main(string[] args)
        {
            int number = 20;
            Console.WriteLine(number);
            Child child = new Child();
            Console.WriteLine(child.varoable);
            Parent p = new Parent();
            Console.WriteLine(p.varoable);

        }
    }
}
