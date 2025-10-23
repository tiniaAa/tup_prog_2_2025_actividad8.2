using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerecicio1.Models
{
    internal class FormatoPatenteNoValidoException: ApplicationException
    {
        public FormatoPatenteNoValidoException() : base() { }
        public FormatoPatenteNoValidoException(string message) : base(message) { }
        public FormatoPatenteNoValidoException(string? message, Exception? innerException) : base(message, innerException) { }
    }
}
