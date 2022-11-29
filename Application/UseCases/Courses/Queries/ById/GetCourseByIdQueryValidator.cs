﻿using FluentValidation;

namespace Application.UseCases.Courses.Queries.ById;

public class GetCourseByIdQueryValidator : AbstractValidator<GetCourseByIdQuery>
{
    public GetCourseByIdQueryValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.Id).NotNull();
    }
}