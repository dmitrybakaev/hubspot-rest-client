using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HubSpotRestClient.Exceptions
{
    public class RestServerException : Exception
    {
        public RestServerException()
        {
        }

        public RestServerException(string message)
            : base(message)
        {
        }

        public RestServerException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
