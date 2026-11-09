using YaeaY.DataHub.Domain.Abstraction.Errors;
using YaeaY.DataHub.Domain.Abstraction.Errors.Enumerators;

namespace YaeaY.DataHub.Domain.Errors.Brazil.CBO;

public static class GreatGroupErrors
{
    public static readonly Error ValidationFailed = new(
    Code: "cbo-great-group.validation.failed",
    Message: "The CBO great group data validation failed.",
    Category: ErrorCategory.Validation,
    Rule: ErrorRule.InvalidValue);

    public static readonly Error CodeInvalid = new(
        Code: "grande-grupo.codigo.invalido",
        Message: "The grande grupo code is invalid.",
        Category: ErrorCategory.Validation,
        Rule: ErrorRule.Required);

    public static readonly Error TitleRequired = new(
        Code: "grande-grupo.titulo.required",
        Message: "The grande grupo title is required.",
        Category: ErrorCategory.Validation,
        Rule: ErrorRule.Required);

    public static readonly Error CompetenceLevelInvalid = new(
        Code: "grande-grupo.nivel-competencia.invalido",
        Message: "The grande grupo competency level is invalid.",
        Category: ErrorCategory.Validation,
        Rule: ErrorRule.Required);
}
