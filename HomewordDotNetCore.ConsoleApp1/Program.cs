public class Program
{
    public static void Main(string[] args)
    {
        // Break;
        //Console.WriteLine("Enter day name: ");
        //string? day = Console.ReadLine();

        //switch (day)
        //{
        //    case "Monday":
        //    case "Tuesday":
        //    case "Wednesday":
        //    case "Thursday":
        //    case "Friday":
        //        Console.WriteLine($"{day} is Weeday");
        //        break;
        //    case "Saturday":
        //    case "Sunday":
        //        Console.WriteLine($"{day} is Weekend");
        //        break;
        //    default:
        //        Console.WriteLine("Empty");
        //        break;
        //}

        // Continue
        Console.WriteLine("Enter first number: ");
        string? first = Console.ReadLine();

        Console.WriteLine("Enter second number: ");
        string? second = Console.ReadLine();

        if (string.IsNullOrEmpty(first) || string.IsNullOrEmpty(second))
        {
            Console.WriteLine("Please fill all fields...");
            return;
        }
        int firstNum = Convert.ToInt32(first);
        int secondNum = Convert.ToInt32(second);

        for (int i = firstNum; i < secondNum; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }

            Console.WriteLine(i);
        }

        Console.WriteLine("Program end ....");

    }
}