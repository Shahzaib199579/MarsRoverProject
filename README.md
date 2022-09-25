# MarsRoverProject
C# .Net 6 project to solve Tech Returners Mars Rover Kata. The solution has a console application in the folder **MarsRover** and an nunit test project in the folder **MarsRover.Test**.

# MarsRover Console Application
The console application has following folders and respective classes within it:

- **Models**: This folders has all the classes with main functionality. 
  - **MissionControl.cs**: This class has methods to create rovers on the plateau, move rovers and show rovers.
  - **Plateau**: This class inherits from **Rectangle** class as plateau is rectangle. This also insures that in future the functionality for a plateau of different shape could be implement. This class holds Rover objects and the position they are on plateau in seperate lists. When creating a rover it checks whether a rover already exists on the point new rover to be created. If there is already a rover then it will show error. Same logic is checked when moving rovers to make sure a rover can not move to the position of another rover. This class also implements several interfaces.
  - **Rover**: This class inherits from **Vehicle**. This will make it easier to implement functionality for other types of vehicles. Its main mething is **MoveRover()** which calls a method in service **DestinationCalculator** to check where the rover needs to go and update the rover position.
  - **Rectangle**: This class inherits from **Shape** class. It only has four **Point** class objects that represent four points of a rectangle.
  - **Vehicle**: This is a base class. It has two important properties which are **Position**, which is a **Point** class object, and other property is **Direction**, which repreasent which direction the vehicle is facing.
  - **Shape**: This is a base class from which **Rectangle** class inherits.
  - **Point**: This class represents the position of something on X and Y plane.
- **Service**: This folder hold interfaces that are used as services.
  - **ICreateService**
  - **IMoveService**
  - **IShowRoversService**
- **Miscellaneous**: This folder holds helpers, Error message class and a **DistanceCalculator** class. The **DistanceCalculator** class is the most important as in it there is logic to check where the rover should move. The method in it returns the destination point to which rover should move. This is then checked to make sure there is no other rover on this point.

# MarsRover.Test NUnit Project
This project holds the **RoverTests** and **PlateauTests** classes that each holds test for respective class in the console application.
