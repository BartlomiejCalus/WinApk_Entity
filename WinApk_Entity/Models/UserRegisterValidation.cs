using FluentValidation;
using WinApk_Entity.Entities;

namespace WinApk_Entity.Models
{
    public class UserRegisterValidation : AbstractValidator<UserRegisterDto>
    {
        ApkDbContext dbContext = new ApkDbContext();
        public UserRegisterValidation()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.Password)
                .MinimumLength(6);

            RuleFor(x => x.ConfirmPassword)
                .Equal(e => e.Password);

            RuleFor(x => x.Email)
                .Custom((value, context) =>
                {
                    var emailUsed = dbContext.Users.Any(u => u.Email == value);

                    if (emailUsed)
                    {
                        context.AddFailure("Email", "Email is taken");
                    }

                });
        }
    }
}
