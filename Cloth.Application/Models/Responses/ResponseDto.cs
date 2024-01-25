﻿namespace Cloth.Application.Models.Responses;

using Cloth.Domain.Entities;
using System.Collections.Generic;

public class ResponseDto
{
    public Filter? Filter { get; set; }
    public IEnumerable<Cloth>? Products { get; set; }
}

