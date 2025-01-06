using System;
using System.Runtime;

namespace SFmodul3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string name;
            int age;
            bool pet;
            float foot_size;

            Console.WriteLine("Как Вас зовут?");
            name = Console.ReadLine();

            Console.WriteLine("Сколько Вам лет?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Есть ли у Вас домашнее животное? да/нет");
            string answer = Console.ReadLine();
            if(answer.ToLower() == "да")
            {
                pet = true;
            }
            else
            {
                pet = false;
            }

            Console.WriteLine("Какой у Вас размер ноги?");
            foot_size = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\n");

            Console.WriteLine("YOUR PROFILE");
            Console.WriteLine("My name is " + name);
            Console.WriteLine("My age is {0}", age);
            Console.WriteLine("Do I have a pet? {0}", pet);
            Console.WriteLine("My shoe size is {0}", foot_size);*/




            /*Semaphor color;
            color = Semaphor.Yellow;
            Console.WriteLine(color.ToString());*/




            /*double result = 10 % 3;
            Console.WriteLine("10 % 3 = {0}", result);

            int olddata = 6;
            string data = olddata.ToString();

            Console.WriteLine(data);
            Console.WriteLine(olddata);*/




            /*Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked((byte) int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1}", name, age);
            Console.Write("What is your favorite day is week? ");
            DaysOfWeek day;
            day = (DaysOfWeek) int.Parse(Console.ReadLine());
            Console.Write("Your favorite day is " + day);
            Console.WriteLine();*/



            /*Console.Write("What is your name? ");
            var name = Console.ReadLine();

            Console.Write("How old are you? ");
            var age = checked((byte)int.Parse(Console.ReadLine()));

            Console.WriteLine("Your name is {0} and age is {1}", name, age);

            Console.Write("What is your favorite week day? ");
            DaysOfWeek day;
            day = (DaysOfWeek) int.Parse(Console.ReadLine());
            Console.Write("Your favorite week day is " + day);
            Console.WriteLine();*/



            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter your age: ");
            var age = checked((byte) int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is " + name + " and age is " + age);
            Console.Write("Enter your birthdate: ");
            Console.WriteLine("Your birthdate is " + Console.ReadLine());
            Console.WriteLine();



            //Console.ReadKey();

        }
    }

    /*enum Semaphor : int
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }*/

    /*enum DaysOfWeek : byte
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }*/
}
