using System;

namespace assignment_one
{
    class Program
    {
        public static void Main(string[] args)
        {
            welcomeModule welcomeModule;

            welcomeModule = new welcomeModule();

            Console.WriteLine(welcomeModule.welcomeUser());
            Console.ReadLine();
            
            Console.Write("Enter your name: ");
            string dogOwner = Console.ReadLine();
            Console.Write("\nEnter your dog's name: ");
            string dogName = Console.ReadLine();
            Console.Write($"\nHow many days will {dogName} be staying with us?: ");
            int daysOfCare = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nSelect the code for additional services you would like provided\n(A, C, or N)\nA - Bathing and Grooming Included- $169.00/day\nC - Bathing Included - $112.00/day\nN - No Additional Services - $75.00/day: ");
            Console.WriteLine();
            Console.WriteLine("Enter the desired Service Package Code: ");
            string serviceCode = Console.ReadLine();
            
            
            //declaring non primitive variable(not number or string but number of memory address) of type estimate
            //address, reference, pointer of object. variable that holds and will take you to a created instance of an object
            estimate CreatedCustomerEstimate; 
            
            CreatedCustomerEstimate = new estimate(dogOwner, dogName, daysOfCare, serviceCode); 
            //[new] keyword used to create new instance of object from the declared class as a method
            //uses constructor from estimate class to create object instances

            
            //setting serviceCodeDesicion based on selected service Code
            int serviceCodeDecision = char.ConvertToUtf32(serviceCode, 0);

            if (serviceCodeDecision == 78)
            {
                Console.WriteLine();
                CreatedCustomerEstimate.TotalCost = CreatedCustomerEstimate.overnightStayN*daysOfCare;
                Console.WriteLine(CreatedCustomerEstimate.quoteGenerator());
            }
            if (serviceCodeDecision == 110)
            {
                Console.WriteLine();
                CreatedCustomerEstimate.TotalCost = CreatedCustomerEstimate.overnightStayN*daysOfCare;
                Console.WriteLine(CreatedCustomerEstimate.quoteGenerator());
            }
            
            
            if (serviceCodeDecision == 65)
            {
                Console.WriteLine();
                CreatedCustomerEstimate.TotalCost = CreatedCustomerEstimate.overnightStayA*daysOfCare;
                Console.WriteLine(CreatedCustomerEstimate.quoteGenerator());
            }
            if (serviceCodeDecision == 97)
            {
                Console.WriteLine();
                CreatedCustomerEstimate.TotalCost = CreatedCustomerEstimate.overnightStayA*daysOfCare;
                Console.WriteLine(CreatedCustomerEstimate.quoteGenerator());
            }

            
            
            
            if (serviceCodeDecision == 67)
            {
                Console.WriteLine();
                CreatedCustomerEstimate.TotalCost = CreatedCustomerEstimate.overnightStayC*daysOfCare;
                Console.WriteLine(CreatedCustomerEstimate.quoteGenerator());
            }
            if (serviceCodeDecision == 99)
            {
                Console.WriteLine();
                CreatedCustomerEstimate.TotalCost = CreatedCustomerEstimate.overnightStayC*daysOfCare;
                Console.WriteLine(CreatedCustomerEstimate.quoteGenerator());
            }

            if (serviceCodeDecision != 78 && serviceCodeDecision != 110 && serviceCodeDecision != 65 && serviceCodeDecision != 97 && serviceCodeDecision != 67 && serviceCodeDecision != 99)
            {
                Console.WriteLine();
                Console.WriteLine("ERROR: Please enter a valid service code. (N, n, A, a, C, or c)");
                
            }


            exitProgram exitProgram;
            exitProgram = new exitProgram();
            Console.WriteLine(exitProgram.goodbyeUser());

            Console.ReadLine();
            Environment.Exit(0);


           

            

            
            
            
           
            
            
            

            


        }
    }


    

   

}


