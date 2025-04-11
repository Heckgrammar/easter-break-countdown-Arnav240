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
            double remainder = 0;

            if (year > 9999)
                year = 9999;

            if (month > 12)
                month = 12;

            if (day < 1)
                day = 1;

            if (hour >= 24)
            {
                day += hour / 24;
                hour = hour % 24;
            }

            if (minutes >= 60)
            {
                hour += minutes / 60;
                minutes = minutes % 60;
            }

            DateTime target = new DateTime(year, month, day, hour, minutes, seconds);

            for (int i = 1; i > 0; i++)
            {
                current = DateTime.Now;
                TimeSpan remaining = target - current;
                Console.WriteLine($"{remaining.Days}d {remaining.Hours}h {remaining.Minutes}m {remaining.Seconds}s");
                Thread.Sleep(1000);
                Console.Clear();

            }
        }
    }
}
