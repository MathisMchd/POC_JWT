﻿namespace BasicApi.Exceptions
{
    internal class InvalidDatabaseConnectionException : Exception
    {
        internal InvalidDatabaseConnectionException(string message) : base(message) { }
    }
    
}
