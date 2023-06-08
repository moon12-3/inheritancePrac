using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancePrac
{
    internal class Program
    {
      
        class Parent
        {
            public Parent() { Console.WriteLine("부모 생성자");  }
            public Parent(int param) { Console.WriteLine("Parent (int param)");  }
            public Parent(string param) { Console.WriteLine("Parant(string param)");  }
        }

        class Child : Parent 
        { 
            public Child()  : base(10)
            {
                Console.WriteLine("Child()  : base(10)");
            }

            public Child(String input) : base(input)
            {
                Console.WriteLine("Child(String input) : base(input)");
            }
        }


        static void Main(string[] args)
        {
            Child childA = new Child();
            Child childB = new Child("string");

            Dog d = new Dog();
            d.Public();
            // d.Protected();
            // d.Private();

            List<Animal> animals = new List<Animal>() { 
                new Dog(), new Dog(), new Dog(),
                new Cat(), new Cat(), new Cat() 
            };

            foreach (var item in animals)
            {
                item.Eat();
                item.Sleep();

                Dog dog = item as Dog;
                if(dog != null)
                {
                    dog.Bark();
                }
                Cat cat = item as Cat;
                if(cat != null)
                {
                    cat.Meow();
                }


                if (item is Dog)
                {
                    ((Dog)item).Bark();
                }
                else if (item is Cat)
                {
                    ((Cat)item).Meow();
                }
            }

        }
    }
}
