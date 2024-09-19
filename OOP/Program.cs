using OOP.UserErrors;

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

            var userErrors = new List<UserError>()
            {
                new TextInputError(),
                new TextInputError(),
                new NumericInputError(),
                new TextInputError(),
                new NumericInputError(),
                new EmptyInputError(),
                new ImageInputError(),
                new TooLongInputError()
            };

            foreach (var userError in userErrors)
            {
                Console.WriteLine(userError.UEMessage());
            }
            Console.WriteLine();

            // F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
            // S: Bird
            // F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
            // S: Animal

            Console.ReadKey(true);
        }
    }
}
