﻿namespace Api.Dtos;

public record StudentTransferRequest
{
    public string Course { get; set; }
    public string Grade { get; set; }
}