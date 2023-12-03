﻿namespace SmsProviders.SmsIr.Exceptions;

internal class UnauthorizedException : SmsIrException
{
    internal UnauthorizedException(byte status, string message)
        : base(status, message)
    {
    }
}