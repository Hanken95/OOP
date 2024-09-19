using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.UserErrors
{
    internal class TooLongInputError : UserError
    {
        public override string UEMessage()
        {
            return "You entered an input that was too long in a field. This fired an error!";
        }
    }
}
