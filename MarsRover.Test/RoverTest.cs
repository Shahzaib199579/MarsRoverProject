using FluentAssertions;
using MarsRover.Miscellaneous;
using MarsRover.Models;
using NUnit.Framework;
using System;

namespace MarsRover.Test;

public class Tests
{
    private Rover _rover;
    [SetUp]
    public void Setup()
    {
        _rover = new();
    }

    [Test]
    public void Rover_Default_Constructor_Should_Create_Correct_Object()
    {
        _rover.CurrentPosition().Should().Be("0 0 N");
    }

    [Test]
    [TestCase(1, 1, RoverDirection.EAST)]
    [TestCase(3, 6, RoverDirection.WEST)]
    public void Rover_Current_Position_Shoul_Return_Correct_Position(int x, int y, char direction)
    {
        // Arrange, Act
        _rover = new Rover(new Point(x, y), direction);

        // Assert
        _rover.CurrentPosition().Should().Be(x.ToString()+" "+y.ToString()+" "+Convert.ToString(direction));
    }

    [Test]
    public void Move_Rover_Method_Should_Move_Rover_To_Correct_Position()
    {
        _rover = new Rover();
        _rover.MoveRover("LLRR").Should().Be("0 0 N");

        _rover.MoveRover("RMLM").Should().Be("1 1 N");

        _rover.MoveRover("RRRR").Should().Be("1 1 N");

        _rover.MoveRover("RRRRR").Should().Be("1 1 E");

        _rover.MoveRover("LLLL").Should().Be("1 1 E");

        _rover.MoveRover("LLLLL").Should().Be("1 1 N");

        _rover.MoveRover("MRMMMLM").Should().Be("4 3 N");
    }
}