namespace _6._Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int per_small = 25;
            int per_large = 35;
            int num_small = 0;
            int num_large = 0;
            double Total = 0;
            double taxes = 6.6;

            Console.WriteLine($"Please Enter The number of small Carpet, noting that the price per piece is {per_small:c} ");
            num_small = int.Parse(Console.ReadLine());
            Console.WriteLine($"Please Enter The number of large Carpet, noting that the price per piece is {per_large:c} ");
            num_large = int.Parse(Console.ReadLine());
            Total = ((num_small * per_small) + (num_large * per_large));

            Console.WriteLine($"the Total Estimat After adding taxes 6% = {(Total + taxes):c}");
        }
    }
}

        
