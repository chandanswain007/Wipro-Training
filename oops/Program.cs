class Start
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Entry Point of your program");
        Employee e = new Employee();
        e.Input();
        e.Display();
    }
}

class Employee
{
    public int a, b,sum;
    public void Input()
    {
        Console.WriteLine("Enter the first number : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number : ");
        int b = Convert.ToInt32(Console.ReadLine());
        int sum = a + b;
        this.a = a;
        this.b = b;
        this.sum = sum;
        Console.WriteLine("Input Method called");
    }
        public void Display()
    {
        Console.WriteLine("Sum of 2 numbers : " + sum);
        Console.ReadKey();
        Console.WriteLine("Employee class Method called");
    }
    
}