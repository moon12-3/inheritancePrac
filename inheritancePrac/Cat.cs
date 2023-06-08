using System;

namespace inheritancePrac
{
    internal class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("야옹 웁니다.");
        }

        public void TestB()
        {
            // Private();
            Protected();
            Public();
        }
    }
}