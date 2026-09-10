using System;
using System.Collections.Generic;
using System.Text;
using YaeaY.DataHub.Domain.Abstraction.Errors.Enumerators;

namespace YaeaY.DataHub.Domain.Abstraction.Errors;

public sealed record Error(string Code, string Message, ErrorCategory Category, ErrorRule Rule)
{
    public static readonly Error None = new(
        Code: string.Empty,
        Message: string.Empty,
        Category: default,
        Rule: default)
    {

    };

    public bool IsNone =>
        string.IsNullOrWhiteSpace(Code) &&
        string.IsNullOrWhiteSpace(Message);
}

