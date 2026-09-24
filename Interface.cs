using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{

        public interface IInsurable
        {
            decimal CalculateInsurance();
        }
     
    
        public interface ITrackable
        {
            string GetTrackingStatus();
        }
    
}
