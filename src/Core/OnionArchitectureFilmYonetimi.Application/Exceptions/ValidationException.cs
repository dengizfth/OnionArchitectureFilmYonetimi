using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureFilmYonetimi.Application.Exceptions
{
    public class ValidationException :Exception
    {
        public ValidationException() : this("Validation error occured")
        {

        }
        public ValidationException(String message) : base(message)
        {

        }
        public ValidationException(Exception ex) : this(ex.Message)
        {
                
        }
     }
}
