using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoomerMusicApp.Exceptions
{
    [Serializable]
    public class EmptyColumnException : Exception
    {
        public EmptyColumnException() { }
        public EmptyColumnException(string message) : base(message) { }

        public EmptyColumnException(string message , Exception innerException) : base(message, innerException) { }
    }
}
