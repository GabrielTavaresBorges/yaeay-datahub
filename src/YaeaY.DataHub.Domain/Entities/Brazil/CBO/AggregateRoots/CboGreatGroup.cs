using YaeaY.DataHub.Domain.Abstraction.Entities;
using YaeaY.DataHub.Domain.Abstraction.Exceptions;
using YaeaY.DataHub.Domain.Abstraction.Interfaces;
using YaeaY.DataHub.Domain.Errors.Brazil.CBO;

namespace YaeaY.DataHub.Domain.Entities.Brazil.CBO.AggregateRoots;

public sealed class CboGreatGroup : Entity, IAggregateRoot
{
    private string _code = string.Empty;
    private string _title = string.Empty;
    private int? _competenceLevel;
    private DateTimeOffset _createdAt;

    public string Code => _code;
    public string Title => _title;
    public int? CompetenceLevel => _competenceLevel;
    public DateTimeOffset CreatedAt => _createdAt;

    private CboGreatGroup() { }

    private CboGreatGroup(string code, string title, int? competenceLevel)
    {
        _code = code;
        _title = title;
        _competenceLevel = competenceLevel;
        _createdAt = DateTimeOffset.UtcNow;
    }

    public static CboGreatGroup Create(string code, string title, int? competenceLevel)
    {
        Validate(code, title, competenceLevel);

        var cboGreatGroup = new CboGreatGroup(code, title, competenceLevel);

        return cboGreatGroup;
    }

    private static void Validate(string code, string title, int? competenceLevel)
    {
        var normalizedCode = code?.Trim() ?? string.Empty;
        if (normalizedCode.Length != 1 || !char.IsDigit(normalizedCode[0]))
            throw new DomainException(GreatGroupErrors.CodeInvalid);

        var normalizedTitle = title?.Trim() ?? string.Empty;
        if (normalizedTitle.Length == 0)
            throw new DomainException(GreatGroupErrors.TitleRequired);

        if (competenceLevel is not null && (competenceLevel < 1 || competenceLevel > 4))
            throw new DomainException(GreatGroupErrors.CompetenceLevelInvalid);
    }
}
