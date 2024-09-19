using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.UserErrors
{
    internal class ImageInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a non-image in a image only field. This fired an error!";
        }
    }
}

