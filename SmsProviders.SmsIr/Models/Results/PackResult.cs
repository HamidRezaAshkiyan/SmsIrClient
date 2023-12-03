using System;

namespace SmsProviders.SmsIr.Models.Results;

public class PackResult
{
    public Guid PackId { get; set; }

    public int RecipientCount { get; set; }

    public int CreationDateTime { get; set; }
}