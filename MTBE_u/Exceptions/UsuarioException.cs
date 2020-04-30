using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTBE_u.Exceptions
{
    public class UsuarioException : Exception
    {
        public string Message;     
        public UsuarioException(string _message)
        {
            Message = _message;
        }
    }
}
