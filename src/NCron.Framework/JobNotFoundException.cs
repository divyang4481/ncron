﻿/*
 * Copyright 2010 Joern Schou-Rode
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace NCron.Framework
{
    /// <summary>
    /// The exception thrown when a job factory does not recognize the name of a job.
    /// </summary>
    public class JobNotFoundException : SystemException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobNotFoundException"/> class.
        /// </summary>
        public JobNotFoundException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobNotFoundException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public JobNotFoundException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobNotFoundException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the innerException parameter is not a null reference (Nothing in Visual Basic), the current exception is raised in a catch block that handles the inner exception.</param>
        public JobNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
