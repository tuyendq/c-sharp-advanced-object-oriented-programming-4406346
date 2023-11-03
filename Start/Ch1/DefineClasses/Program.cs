// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Create some new Rectangle objects with dimensions
Rectangle rect1 = new Rectangle(3, 5);
Rectangle rect2 = new Rectangle(40);
System.Console.WriteLine(rect1.GetArea());
System.Console.WriteLine(rect2.GetArea());

// TODO: Change the values of width and height
rect2.height = 50;
System.Console.WriteLine(rect2.GetArea());
