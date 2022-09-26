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
        public void Plateau_Create_Rover_Should_Give_Error_If_Either_X_Or_Y_Of_Coordinate_Negative()
        {
            _plateau.CreateRover(-1, 0, RoverDirection.NORTH).Should().Contain(ErrorMessages.ERROR);
            _plateau.CreateRover(0, -2, RoverDirection.EAST).Should().Contain(ErrorMessages.ERROR);
            _plateau.CreateRover(-5, -2, RoverDirection.EAST).Should().Contain(ErrorMessages.ERROR);
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

        [Test]
        public void Plateau_Move_Rover_Should_Move_Rover_To_New_Position()
        {
            _plateau.CreateRover(1,1, RoverDirection.NORTH);
            _plateau.MoveRover("RM").Should().Be("2 1 E");

            _plateau.CreateRover(1, 1, RoverDirection.NORTH);
            _plateau.MoveRover("MR").Should().Be("1 2 E");

            _plateau.CreateRover(1, 1, RoverDirection.EAST);
            _plateau.MoveRover("LLM").Should().Be("0 1 W");
        }

        [Test]
        public void Plateau_Move_Rover_Should_Not_Move_Rover_To_Point_Where_Another_Rover()
        {
            _plateau.CreateRover(1, 1, RoverDirection.NORTH);
            var result = _plateau.MoveRover("RM");

            _plateau.CreateRover(1, 1, RoverDirection.NORTH);
            _plateau.MoveRover("RM").Should().Contain(ErrorMessages.ERROR);
        }
    }
}
