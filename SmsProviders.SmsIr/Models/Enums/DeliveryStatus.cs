namespace SmsProviders.SmsIr.Models.Enums;

/// <summary>
/// Represents the delivery status of a message.
/// </summary>
public enum DeliveryStatus
{
    /// <summary>
    /// The message has been delivered to the phone.
    /// </summary>
    /// <remarks>
    /// رسیده به گوشی
    /// </remarks>
    Delivered = 1,

    /// <summary>
    /// The message has not been delivered to the phone.
    /// </summary>
    /// <remarks>
    /// نرسیده به گوشی
    /// </remarks>
    Undelivered = 2,

    /// <summary>
    /// The message is being processed by the telecommunications network.
    /// </summary>
    /// <remarks>
    /// پردازش در مخابرات
    /// </remarks>
    Processing = 3,

    /// <summary>
    /// The message has not reached the telecommunications network.
    /// </summary>
    /// <remarks>
    /// نرسیده به مخابرات
    /// </remarks>
    Unreachable = 4,

    /// <summary>
    /// The message has been received by the operator.
    /// </summary>
    /// <remarks>
    /// رسیده به اپراتور
    /// </remarks>
    Received = 5,

    /// <summary>
    /// The message has failed to be delivered.
    /// </summary>
    /// <remarks>
    /// ناموفق
    /// </remarks>
    Failed = 6,

    /// <summary>
    /// The message has been blocked by a blacklist.
    /// </summary>
    /// <remarks>
    /// لیست سیاه
    /// </remarks>
    Blacklisted = 7
}
