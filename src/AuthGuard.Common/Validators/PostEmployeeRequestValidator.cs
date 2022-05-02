using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AuthGuard.Contracts.Requests;
using FluentValidation;

namespace AuthGuard.Common.Validators
{
    public class PostEmployeeRequestValidator : AbstractValidator<PostEmployeeRequest>
    {
        public PostEmployeeRequestValidator()
        {
            RuleFor(x=>x.BirthDate)
                .NotNull()
                .GreaterThan(DateTime.Now.AddYears(-100))
                .LessThan(DateTime.Now.AddYears(-18));

            RuleFor(x=>x.Name)
                .NotNull()
                .NotEmpty();

            RuleFor(x=>x.Surname)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Gender)
                .GreaterThanOrEqualTo(0)
                .LessThanOrEqualTo(2);

        }
    }
}
