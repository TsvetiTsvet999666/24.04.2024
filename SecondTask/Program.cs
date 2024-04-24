namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Chicken chicken1 = new Chicken("Mira", 10);
                Console.WriteLine($"Name: {chicken1.Name}, Age: {chicken1.Age}");
                Chicken chicken2 = new Chicken("Mira", 17); 
                Console.WriteLine($"Name: {chicken2.Name}, Age: {chicken2.Age}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
