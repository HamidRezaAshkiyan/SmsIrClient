using System;

namespace SmsProviders.SmsIr.Exceptions;

internal class SmsIrException : Exception
{
    internal readonly byte Status;

    internal SmsIrException(byte status, string message) : base(message)
    {
        Status = status;
    }
}