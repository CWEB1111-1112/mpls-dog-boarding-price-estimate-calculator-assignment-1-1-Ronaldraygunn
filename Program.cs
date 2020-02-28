using System;

namespace assignment_one
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            //declaring non primitive variable(not number or string but number of memory address) of type estimate
            //address, reference, pointer of object. variable that holds and will take you to a created instance of an object

            estimate customerEstimate; 
            
            customerEstimate = new estimate("Douglas", "fido", 5, "c"); //[new] keyword used to create new instance of object from the declared class as a method
            
            // [customerEsimate.] arrives at address of created object
            //can then see values stored in object

            


        }
    }


    

   

}


