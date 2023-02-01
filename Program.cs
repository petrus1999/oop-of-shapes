using oop_of_shapes;
class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Square", "Four sides", "Four equal sides");
        Square rectangle = new Square("Rectangle", "Four sides", "2 sets of 2 equal sides");
        Square triangle = new Square("Triangle", "Three sides", "It can have  2 or 3 equal sides");
        Square pentagon = new Square("Pentagon", "Five sides", "5 sides (can be equal or unequal)");


        Console.WriteLine(square.Name +" "+square.Numberofsides+" "+square.Properties);
        Console.WriteLine(rectangle.Name + " " + rectangle.Numberofsides + " " + rectangle.Properties);
        Console.WriteLine(triangle.Name + " " + triangle.Numberofsides + " " + triangle.Properties);
        Console.WriteLine(pentagon.Name + " " + triangle.Numberofsides + " " + triangle.Properties);
    }
}
