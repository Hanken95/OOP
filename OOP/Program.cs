using OOP.Animals;
using OOP.Person;
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

            List<Animal> animals = new List<Animal>()
            {
                new Bird(){Name ="Neo", Age = 3, CanFly = false, Weight = 5},
                new Dog(){Name ="Leo", Age = 4,HuntingDog = true , Weight = 15},
                new Flamingo(){Name ="Hilda", Age = 3, CanFly = true, Weight = 5, Eyes = 10},
                new Hedgehog(){Name ="Felix", Age = 4, IsCute = true , Weight = 7},
                new WolfMan(){Name ="Berit", Age = 45, NumberOfTeeth = 25 , Weight = 7},
            };

            //Här går den igenom varje animal och använder deras stats och går in och kollar specifikt om de har något specifikt under sin egna
            //Stat() metod annars skriver den ut standard Stats() metoden. Den kollar även vad varje specifikt djurs DoSound() är och
            //Tilkallar den metoden.
            foreach(var animal in animals)
            {
                Console.WriteLine(animal.Stats());
                animal.DoSound();
                if (animal is IPerson)
                {
                    var person = (IPerson)animal;
                    person.Talk();
                }
            }

            List<Dog> dogs = new List<Dog>();
            //dogs.Add(new Horse());
            //Går inte för att medans både hundar och hästar är djur så är inte hästar hundar
            //Det måste vara en lista av Animals för att alla klasser(i denna sektionen) skall kunna läggas till

            //DogString() funkar här för här så tar vi bara ut alla hundar och då kan vi aktivera den metoden
            foreach(Dog dog in animals)
            {
                Console.WriteLine(dog.Stats());
                dog.DogString();
            }

            //Det funkar inte här för här är alla inte Dog och det betyder att alla inte har den metodet så alla kan inte köras utan en cast
            foreach (var animal in animals)
            {
                //animal.DogString();

                //Detta funkar dock, eftersom vi castat den och nu vet att det är en Dog
                if (animal is Dog)
                {
                    var dog = (Dog)animal;
                    dog.DogString();
                }
            }

            Console.ReadKey(true);
        }
    }
}
