namespace Assignment_5._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print the first n Natural numbers: ");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("How many numbers to Print: ");

            int count = Convert.ToInt32(Console.ReadLine());

            PrintNatural(1, count);
            Console.WriteLine();
        }

        static int PrintNatural(int value,  int count)
        {
            if ( count < 1 )
            {
                return value;
            }
            count--;
            Console.Write("{0}", value);
            return PrintNatural(value + 1, count);
        }
    }
}
