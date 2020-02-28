using System;

namespace assignment_one
{
    class estimate
    {
        //instance variable declaration
        //every created instance will be assigned unique values for the instance variables within the class
        public string DogOwner { get; set; }
        public string DogName { get; set; }
        public int DaysOfCare { get; set; }
        public string ServiceCode { get; set; }
        public double TotalCost { get; set; }

        public double overnightStayN = 75.00;
        public string ServiceCodeN = "N";
        public double overnightStayA = 169.00;
        public string ServiceCodeA = "A";
        public double overnightStayC = 112.00;
        public string ServiceCodeC = "C";



        public estimate(string dogOwner, string dogName, int daysOfCare, string serviceCode)
        {
            this.DogOwner = dogOwner;
            this.DogName = dogName;
            this.DaysOfCare = daysOfCare;
            this.ServiceCode = serviceCode;
        }

        public string quoteGenerator()
        {
            return String.Format($"Thank you {DogOwner}! {DogName} will be staying with us for {DaysOfCare} days. You have selected Service Package {ServiceCode} bringing the total cost to ${TotalCost}.");
            
        }

        
        
        
        
        
        
    }

}