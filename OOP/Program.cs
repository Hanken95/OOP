namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { FName = "Jeff", LName = "Balthasar"};
            //person.age = 3; går inte. Kommer inte åt fältet direkt
            //Men detta funkar
            person.Age = 3;

            person.FName = "a";
        }
    }
}
