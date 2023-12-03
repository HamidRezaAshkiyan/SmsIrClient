namespace SmsProviders.SmsIr.Models.Enums;

public enum SmsStatusCodes
{
    Success = 1,
    SystemError = 0,
    InvalidWebServiceKey = 10,
    InactiveWebServiceKey = 11,
    WebServiceKeyLimitedToDefinedIPs = 12,
    InactiveAccount = 13,
    SuspendedAccount = 14,
    RequestLimitExceeded = 20,
    InvalidLineNumber = 101,
    InsufficientCredit = 102,
    EmptyMessage = 103,
    InvalidMobileNumber = 104,
    ExceedsMaximumNumberOfMobileNumbers = 105,
    ExceedsMaximumNumberOfMessages = 106,
    EmptyMobileNumberList = 107,
    EmptyMessageList = 108,
    InvalidSendDateTime = 109,
    MobileNumberAndMessageCountMismatch = 110,
    MessageIdNotFound = 111,
    RecordNotFoundForDeletion = 112,
    FormatNotFound = 113,
    ParameterValueExceedsMaximumLength = 114,
    MobileNumberInBlackList = 115,
    ParameterNameCannotBeEmpty = 116,
    InvalidMessageContent = 117,
    ExceedsMaximumNumberOfMessagesAllowed = 118
}