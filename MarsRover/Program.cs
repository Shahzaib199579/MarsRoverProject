// See https://aka.ms/new-console-template for more information
using MarsRover.Miscellaneous;
using MarsRover.Models;

var input = Console.ReadLine();
var sizeArr = input.Split(" ");
var maxXCoor = Convert.ToInt32(sizeArr[0]);
var maxYCoor = Convert.ToInt32(sizeArr[1]);

var missionControl = new MissionControl(new Point(maxXCoor, maxYCoor), new Point(0, 0));

do
{
    string result = "";
    do
    {
        input = Console.ReadLine();
        if (!String.IsNullOrEmpty(input))
        {
            var inputArr = input.Split(" ");
            result = missionControl.MissionPlateu.CreateRover(Convert.ToInt32(inputArr[0]),
                                                     Convert.ToInt32(inputArr[1]),
                                                     Convert.ToChar(inputArr[2]));
        }
    } while (result.Contains(ErrorMessages.ERROR));
    do
    {
        input = Console.ReadLine();
        if (!String.IsNullOrEmpty(input))
        {
            result = missionControl.MoveRover(input);
        }
    } while (result.Contains(ErrorMessages.ERROR));
} while (!String.IsNullOrEmpty(input));

missionControl.ShowRovers();
Console.ReadLine();
