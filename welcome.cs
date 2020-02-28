using System;

namespace assignment_one
{
    class welcomeModule
    {
        public string welcomeMsg = "Welcome to MPLS Dog Boarding Services. Press [Enter] key to create a Boarding Cost Estimate.";
        public string welcomeUser()
        {
            return String.Format(welcomeMsg);
            
        }
    }
}