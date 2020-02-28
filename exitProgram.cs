using System;

namespace assignment_one
{
    class exitProgram
    {
        
        public string exitMsg = $"Thank you for choosing MPLS Dog Boarding!\nPlease press [Enter] key to exit the program";
        public string goodbyeUser()
        {
            return String.Format(exitMsg);
            
        }
    }
}