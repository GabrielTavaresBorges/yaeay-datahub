using YaeaY.DataHub.Domain.Abstraction.Entities;
using YaeaY.DataHub.Domain.Abstraction.Exceptions;
using YaeaY.DataHub.Domain.Abstraction.Interfaces;
using YaeaY.DataHub.Domain.Errors.Brazil.CBO;

namespace YaeaY.DataHub.Domain.Entities.Brazil.CBO.AggregateRoots;

public sealed class CboMainSubgroup : Entity, IAggregateRoot
{
    private string _code = string.Empty;
    private Guid _greatGroupId;
    private string _title = string.Empty;
    private DateTimeOffset _createdAt;

    public string Code => _code;
    public Guid GreatGroupId => _greatGroupId;
    public string Title => _title;
    public DateTimeOffset CreatedAt => _createdAt;

    private CboMainSubgroup() { }

    private CboMainSubgroup(string code, Guid greatGroupId, string title)
    {
        _code = code;
        _greatGroupId = greatGroupId;
        _title = title;
        _createdAt = DateTimeOffset.UtcNow;
    }

    public static CboMainSubgroup Create(string code, Guid greatGroupId, string title)
    {
        Validate(code, greatGroupId, title);

        var cboMainSubgroup = new CboMainSubgroup(code, greatGroupId, title);

        return cboMainSubgroup;
    }

    private static void Validate(string code, Guid greatGroupId, string title)
    {
        var normalizedCode = code?.Trim() ?? string.Empty;
        if (normalizedCode.Length != 2 || !normalizedCode.All(char.IsDigit))
            throw new DomainException(MainSubgroupErrors.CodeInvalid);

        if (greatGroupId == Guid.Empty)
            throw new DomainException(MainSubgroupErrors.GreatGroupRequired);

        var normalizedTitle = title?.Trim() ?? string.Empty;
        if (normalizedTitle.Length == 0)
            throw new DomainException(MainSubgroupErrors.TitleRequired);
    }
}
