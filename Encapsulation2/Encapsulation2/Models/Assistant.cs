using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation2.Models
{
    internal class Assistant : Employee
    {


        public static void GetFeedBack(Employee employee)
        {
            if (IsSuccessfull)
            {
                GetPromotion();
            }
        }
    }
}
