namespace Topic_3___User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string response;
            string statement;


            string yourName;
            int yourAge, currentYear, birthYear;
            DateTime yearGrab = DateTime.Now;
            currentYear = yearGrab.Year;
            Console.WriteLine("Hello, could you please tell me your name?");
            yourName = Console.ReadLine();
            Console.WriteLine("Next, your age.");
            statement = Console.ReadLine();
            yourAge = Convert.ToInt32(statement);
            Console.WriteLine("Lastly, your birth year.");
            response = Console.ReadLine();
            birthYear = Convert.ToInt32(response);

            if (birthYear > currentYear)
            {
                Console.WriteLine("No you aren't. Stop lying to me.");
            }

            if (birthYear < currentYear)
            {


                Console.WriteLine("Hello there, " + yourName + ". You are " + yourAge + " years old, you were born in the year " + birthYear + ", and the current year is " + currentYear + ".");

            }
            
            
            int num, num2, num3;

            Console.WriteLine("Give me a whole number.");
            num = Convert.ToInt32(Console.ReadLine);
            Console.WriteLine("Give me a second whole number.");
            num2 = Convert.ToInt32(Console.ReadLine);
            Console.WriteLine("Give me one more whole number.");
            num3 = Convert.ToInt32(Console.ReadLine);
            int totalNum = num + num2 + num3;
            Console.WriteLine("I will now add up these numbers. Your total is ");

        }


    }
}