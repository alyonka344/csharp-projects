﻿using System.Collections;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceShips.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceShips.Services.FlightResult;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TestsGenerator5 : IEnumerable<object[]>
{
    private readonly List<object[]> _data = new()
    {
        new object[] { new PleasureShuttle(), typeof(ShipLoss) },
        new object[] { new Vaklas(), typeof(Success) },
    };

    public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}