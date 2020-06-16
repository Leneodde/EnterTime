namespace EnterTimeApplication
{
    public class Strings
    {
        public void EnterTime()
        {
            Console.Write("Enter time: ");
            var inputTime = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(inputTime))
            {
                Console.WriteLine("Invalid time");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid time");
                return;
            }
            
            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("OK");
                else
                    Console.WriteLine("Invalid time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid time");
            }
        }
    }
}
