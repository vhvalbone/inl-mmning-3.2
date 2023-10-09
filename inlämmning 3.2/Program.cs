using System;
namespace inlämning_3._2;
class Program
{
    static void Main()
    {
        Console.Write("Har du gått ut gymnasiet än? (j/n): ");
        char harGåtUtGymnasiet = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (harGåtUtGymnasiet == 'j' || harGåtUtGymnasiet == 'J')
        {
            Console.Write("Hur gammal är du? Ange ålder: ");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder < 22)
            {
                Console.WriteLine("Vi vill att du jobbor hos oss.");
            }
            else
            {
                Console.WriteLine("Vi kan tyvärr inte anställa dig då du är för gammal.");
            }
        }
        else
        {
            Console.WriteLine("Vi kan tyvärr inte anställa dig.");
        }
    }
}

