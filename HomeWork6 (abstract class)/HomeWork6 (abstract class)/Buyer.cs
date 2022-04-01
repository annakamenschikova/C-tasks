using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork6__abstract_class_
{
    abstract class Buyer 
    {
        public string PaymentMethod { get; }

        public abstract string Pay(); //or public virtual string Pay() + row below
       /* {
            return System.String.Format("Payment method is {0}", PaymentMethod);
        }*/
    }

         
}
                


