using System;

namespace assignment_one
{
    class estimate
    {
        public string dogOwner { get; set; }
        public string dogName { get; set; }
        public int daysOfCare { get; set; }
        public string serviceCode { get; set; }

        public double overnightStayN = 75.00;
        public double overnightStayA = 169.00;
        public double overnightStayC = 112.00;

        
        
        
        public static void getOwnerName()
        {
            Console.WriteLine("Enter your first and last name:");
            Console.ReadLine();
        }
        
        public static void getDaysOfCare()
        {
            Console.WriteLine("Enter the amount of days your dog will be staying:");
            Console.ReadLine();
        }
        
    }

}