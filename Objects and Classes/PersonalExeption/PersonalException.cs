using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalException
{
    class PersonalExceptions : Exception
    {
        public PersonalExceptions() : base("My first exception is awesome!!!")
        {
            
        }
    }
}
