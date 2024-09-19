using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.UserErrors
{
    internal class EmptyInputError : UserError
    {
        public override string UEMessage()
        {
            return "You entered an empty input in a field. This fired an error!";
        }
    }
}
