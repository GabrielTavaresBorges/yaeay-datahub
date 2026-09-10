namespace YaeaY.DataHub.Domain.Abstraction.Errors.Enumerators;

public enum ErrorRule
{
    None,
    Required,
    MaximumLength,
    MinimumLength,
    InvalidFormat,
    AlreadyExists,
    NotFound,
    InvalidValue,
    InvariantViolation,
    Unexpected
}
