using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name,string []Dishes) User;
            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();
            User.Dishes = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ваше любимое блюдо номер{0}:",i+1);
                User.Dishes[i] = Console.ReadLine();
            }
            Console.Write(User.Dishes);
            Console.WriteLine(User.Name);
        }
    }
}
