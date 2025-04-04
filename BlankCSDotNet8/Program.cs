namespace BlankCSDotNet8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            Console.WriteLine("What is the target year in 4 digits");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the target month (in number)");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the target day (Number date)");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the target hour (Number)");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the target minutes (Number)");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the target seconds (Number)");

            int seconds = Convert.ToInt32(Console.ReadLine());
            DateTime target = new DateTime(year, month, day, hour, minutes, seconds);

            for (int i = 1; i > 0; i++)
            {
                current = DateTime.Now;
                Console.WriteLine((target - current));
                Thread.Sleep(1000);
                Console.Clear();

            }
        }
    }
}
