using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using MarsRover.Miscellaneous;
using MarsRover.Models;
using NUnit.Framework;

namespace MarsRover.Test
{
    public class PlateauTests
    {
        private Plateau _plateau;
        [SetUp]
        public void Setup()
        {
            _plateau = new(new Point(5,5), new Point(0, 0));
        }

        [Test]
        public void Plateau_Create_Rover_Should_Create_Rover_On_Some_Point()
        {
            _plateau.CreateRover(0, 0, RoverDirection.NORTH).Should().Be(String.Empty);
            _plateau.CreateRover(1, 1, RoverDirection.EAST).Should().Be(String.Empty);
        }

        [Test]
        public void Plateau_Create_Rover_Should_Not_Create_Rover_On_Same_Point()
        {
            _plateau.CreateRover(1, 1, RoverDirection.EAST).Should().Be(String.Empty);
            _plateau.CreateRover(1, 1, RoverDirection.EAST).Should().Contain(ErrorMessages.ERROR);
        }
    }
}
