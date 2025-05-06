class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write your first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Write your last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Write your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Write weight: ");
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine("Write your height: ");
        double height = double.Parse(Console.ReadLine());
        double bmi = BMI(weight, height);
        Console.WriteLine($"Your profile:\n " +
                          $"Full name: {firstName} {lastName}\n " +
                          $"Age: {age}\n" +
                          $" Weight: {weight}\n" +
                          $" Height: {height}\n " +
                          $"Body Mass Index: {bmi} ");
    }

    static double BMI(double weight, double height)
    {
        return weight / (height * height);
    }
}