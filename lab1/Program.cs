namespace  lab1
{
    internal class program
    {
        static void main(string[] args)
        {
            Console.WriteLine(" enter the length of the rectangle :");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the width of the rectangle:");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;
            Console.WriteLine($"The area of the rectangle is : {area}");
            Console.ReadLine();
        }
    }      
}