using YaeaY.DataHub.Domain.Abstraction.Errors;
using YaeaY.DataHub.Domain.Abstraction.Errors.Enumerators;

namespace YaeaY.DataHub.Domain.Errors.Brazil.CBO;

public static class MainSubgroupErrors
{
    public static readonly Error ValidationFailed = new(
        Code: "cbo-main-subgroup.validation.failed",
        Message: "The CBO main subgroup data validation failed.",
        Category: ErrorCategory.Validation,
        Rule: ErrorRule.InvalidValue);

    public static readonly Error CodeInvalid = new(
        Code: "cbo-main-subgroup.code.invalid",
        Message: "The CBO main subgroup code is invalid.",
        Category: ErrorCategory.Validation,
        Rule: ErrorRule.InvalidValue);

    public static readonly Error GreatGroupRequired = new(
        Code: "cbo-main-subgroup.great-group.required",
        Message: "The CBO great group is required.",
        Category: ErrorCategory.Validation,
        Rule: ErrorRule.Required);

    public static readonly Error TitleRequired = new(
        Code: "cbo-main-subgroup.title.required",
        Message: "The CBO main subgroup title is required.",
        Category: ErrorCategory.Validation,
        Rule: ErrorRule.Required);
}
