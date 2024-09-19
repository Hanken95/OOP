namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            //person.age = 3; går inte. Kommer inte åt fältet direkt
            //Men detta funkar
            person.Age = 3;

        }
    }
}
