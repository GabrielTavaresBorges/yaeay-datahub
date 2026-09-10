using YaeaY.DataHub.Domain.Abstraction.Errors;

namespace YaeaY.DataHub.Domain.Abstraction.Result;

public interface IValidationResult<TSelf> where TSelf : IValidationResult<TSelf>
{
    static abstract TSelf Failure(Error error);
}
