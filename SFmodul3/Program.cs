using System.Runtime;

namespace SFmodul3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
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
            Console.WriteLine("My shoe size is {0}", foot_size);

            //Console.ReadKey();


        }
    }
}
