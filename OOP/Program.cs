namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person() { };
            //person.age = 3; går inte. Kommer inte åt fältet direkt
            //Men detta funkar
            //person.Age = 3;

            var personHandler = new PersonHandler();
            var person1 = personHandler.CreatePerson(20, "Bob", "Liamsson", 30, 160);
            var person2 = personHandler.CreatePerson(20, "Linda", "Liamsson", 22, 150);
            var person3 = personHandler.CreatePerson(20, "Fel", "Friars", 15, 65);

            personHandler.GrowTaller(person1, 5);
            personHandler.ChangeName(person2, newLName: "Fredriksdottir");
            personHandler.ChangeWeight(person3, -5);
            personHandler.SetAge(person2, 23);

        }
    }
}
