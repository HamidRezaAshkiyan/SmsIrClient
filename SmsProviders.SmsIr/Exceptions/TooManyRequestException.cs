﻿namespace SmsProviders.SmsIr.Exceptions;

internal class TooManyRequestException : SmsIrException
{
    internal TooManyRequestException(byte status, string message)
        : base(status, message)
    {
    }
}