using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAdd.Application.Expections
{
    public class ValidationExpection : Exception
    {
        public ValidationExpection() : this("Validation error occured")
        {
        }

        public ValidationExpection(String Message):base(Message) 
        {
            
        }

        public ValidationExpection(Exception ex):this(ex.Message) 
        {
            
        }
    }
}
