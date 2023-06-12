using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowingHidingPeac
{
    internal class Program
    {
        class Animal
        {
            public virtual void Eat()
            {
                Console.WriteLine("냠냠 먹습니다.");
            }
        }

        class Dog : Animal 
        { 
            public void Eat()
            {
                Console.WriteLine("촵촵 먹습니다");
            }
        }

        class Cat : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("뇸뇸 먹습니다");
            }
        }

        class Parent
        {
            public int varoable = 273;
            public void Method()
            {
                Console.WriteLine("부모의 메소드");
            }
            public virtual void Method2() 
            { 
                Console.WriteLine("부모의 메소드"); 
            }
        }

        class Child : Parent 
        {
            public new string varoable = "shadowing";
            public new void Method()
            {
                Console.WriteLine("자식의 메소드");
            }
            public override void Method2() 
            {
                Console.WriteLine("자식의 메소드");
            }
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

            child.Method();
            p.Method();

            child.Method2();
            p.Method2();

            List<Animal> list = new List<Animal>()
            {
                new Dog(), new Cat(), new Dog(), new Cat(),
                new Dog(), new Cat(), new Dog(), new Cat()
            };
            foreach (var item in list) {
                item.Eat();
            }
        }
    }
}
