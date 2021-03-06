// Copyright (c) Microsoft Corporation
// All rights reserved. 
//
// MIT License
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING 
// BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, 
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE. 

namespace Microsoft.GFS.WCS.Test
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Is thrown when command line argument is invalid.
    /// </summary>
    [Serializable]
    public class CommandLineArgumentException : ArgumentException
    {
        /// <summary>
        /// Initializes a new instance of the CommandLineArgumentException class.
        /// </summary>
        public CommandLineArgumentException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommandLineArgumentException class.
        /// </summary>
        /// <param name="message">Error text.</param>
        public CommandLineArgumentException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommandLineArgumentException class.
        /// </summary>
        /// <param name="message">Error text.</param>
        /// <param name="innerException">Inner exception.</param>
        public CommandLineArgumentException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommandLineArgumentException class.
        /// </summary>
        /// <param name="message">Error text.</param>
        /// <param name="paramName">Command line parameter name.</param>
        /// <param name="innerException">Inner exception.</param>        
        public CommandLineArgumentException(string message, string paramName, Exception innerException)
            : base(message, paramName, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommandLineArgumentException class.
        /// </summary>
        /// <param name="message">Error text.</param>
        /// <param name="paramName">Command line parameter name.</param>
        public CommandLineArgumentException(string message, string paramName)
            : base(message, paramName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommandLineArgumentException class.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        protected CommandLineArgumentException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
