using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    class TimeTravelException : Exception
    {
        public TimeTravelException()
        {
        }

        public TimeTravelException(string message) : base(message)
        {
        }

        public TimeTravelException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TimeTravelException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
