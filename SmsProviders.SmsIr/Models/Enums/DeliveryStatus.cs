namespace SmsProviders.SmsIr.Models.Enums;

public enum DeliveryStatus
{
    Delivered = 1, // رسیده به گوشی
    Undelivered = 2, // نرسیده به گوشی
    Processing = 3, // پردازش در مخابرات
    Unreachable = 4, // نرسیده به مخابرات
    Received = 5, // رسیده به اپراتور
    Failed = 6, // ناموفق
    Blacklisted = 7 // لیست سیاه
}