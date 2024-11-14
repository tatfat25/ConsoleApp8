using System;
namespace ConsoleApp8
{
    class Program
    {
       static void Main (string[] args)
        {
            Console.WriteLine("Har du gått ut ur gymnasiet svara j för ja och n för nej");
            string Gymnasie = Console.ReadLine();
            Console.WriteLine("Vad är din ålder");
            int Ålder = int.Parse(Console.ReadLine());
            if (Gymnasie == "j" && Ålder <= 22)
            {
                Console.WriteLine("Vi vill anställa dig");
            } 
            else
            {
                Console.WriteLine("Vi vill inte anställa dig");
            }
        }
    }
}