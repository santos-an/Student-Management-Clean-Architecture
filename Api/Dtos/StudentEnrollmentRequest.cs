﻿namespace Api.Dtos;

public record StudentEnrollmentRequest
{
    public string Course { get; set; }
    public string Grade { get; set; }
}