using System;

namespace App
{
    class App
    {
        public static int month = 0;
        public static int currentMonth = 0;
        public static int currentDay;
        public static int birthday;

        public static void DaysCal(int month, int currentMonth, 
            int currentDay, int birthday)
        {
            Console.WriteLine($"Your Birthday is in: { (month - currentMonth + 10)} Month's");
            Console.WriteLine($"Your Birthday is in: { (Math.Abs(currentDay - birthday))} Days");
        }

        
        static void Main(string[] args)
        {
         
            Console.WriteLine("Enter Current Month: ");
            currentMonth = Convert.ToInt16(Console.ReadLine());
           
            Console.WriteLine("Enter Birthday Month: ");
            month = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Enter Current Day: ");
            currentDay = Convert.ToInt16(Console.ReadLine());
           
            Console.WriteLine("Enter Current Day: ");
            birthday = Convert.ToInt16(Console.ReadLine());

            App.DaysCal(currentMonth, month, currentDay, birthday);

        }
        
        
    }
}