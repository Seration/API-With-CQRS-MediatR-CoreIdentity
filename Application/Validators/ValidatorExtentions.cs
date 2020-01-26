using FluentValidation;

namespace Application.Validators
{
    public static class ValidatorExtentions
    {
        public static IRuleBuilder<T, string> Password<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            var options = ruleBuilder
                .NotEmpty()
                .MinimumLength(6).WithMessage("Password must be at least 6 characters")
                .Matches("[A-Z]").WithMessage("Password must cotain 1 uppercase letter")
                .Matches("[a-z]").WithMessage("Password must cotain 1 lowercase letter")
                .Matches("[0-9]").WithMessage("Password must cotain a number")
                .Matches("[^a-aA-Z0-9]").WithMessage("Password must cotain non alphanumeric");
            
            return options;
        }
    }
}