namespace MethodsandTryParse_AdamIshak
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("*********");
            Console.WriteLine(" ******* ");
            Console.WriteLine("  *****  ");
            Console.WriteLine("   ***   ");
            Console.WriteLine("    *    ");
            Console.WriteLine("    *    ");
            Console.WriteLine("   ***   ");
            Console.WriteLine("  *****  ");
            Console.WriteLine(" ******* ");
            Console.WriteLine("*********");
            Console.WriteLine("XXXXXXXXX");
            Console.WriteLine("*********");
            Console.WriteLine(" ******* ");
            Console.WriteLine("  *****  ");
            Console.WriteLine("   ***   ");
            Console.WriteLine("    *    ");
            Console.WriteLine("    *    ");
            Console.WriteLine("   ***   ");
            Console.WriteLine("  *****  ");
            Console.WriteLine(" ******* ");
            Console.WriteLine("*********");
        }
        static void DownArrow()
        {
            Console.WriteLine("*********");
            Console.WriteLine(" ******* ");
            Console.WriteLine("  *****  ");
            Console.WriteLine("   ***   ");
            Console.WriteLine("    *    ");

            Console.WriteLine("DownArrow");
            Console.WriteLine("UpArrow");
            Console.WriteLine("DownArrow");

            Console.WriteLine("***");
            Console.WriteLine("*");
            Console.WriteLine("---");

            Console.WriteLine("Part1");
            Console.WriteLine("Part2");
            Console.WriteLine("Part1");
            Console.WriteLine("Part3");

            Console.WriteLine("***");
            Console.WriteLine("*");
            Console.WriteLine("***");
            Console.WriteLine("---");


            Console.WriteLine("Create 4 methods");
            Console.WriteLine("addition, subtract, multiplcation, and division");
            Console.WriteLine("They should all take 2 paremeters at least");
            Console.WriteLine("The should return doubles");

            Console.WriteLine($"1. 12 + 5");
            Console.WriteLine($" 2. 902 / 73");
            Console.WriteLine($" 3. 658 * 23");
            Console.WriteLine($"4. 5 - 72");
            Console.WriteLine($"5. 72 * 3 / 4");
            Console.WriteLine($"6. 17 + 42 * 76 - 19 / 12");
            Console.WriteLine($"7. 82.7 * (52.33 * 84) - 12 / 54");
            Console.WriteLine($"8. Math.Pi * (r * r) * (h / 3");
            Console.WriteLine("pi * 5^ * 5 / 3 ");
        }


        static void Main()
        {
            double p1 = (12 * 5);      // p1 = 12 * 5
            double p2 = (12 * 5 / 7);        // p2 = (12 * 5) / 7
            double p3 = (54 - 12 * 5 / 7);     // p3 = 54 - ((12 * 5) / 7)
            double final = (54 - 12 * 5 / 7 + 2);        // final = 54 - ((12 * 5) / 7) + 2
            Console.WriteLine($"Result: {Math.Round(final, 2)}");


        }
            
        
        
       
           
        

    }

}
