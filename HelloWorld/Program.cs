namespace HelloWorld
{
    class Program

    {
        static void Main()
        {
            DateOnly dateconverted = new DateOnly();
            string nameInput;
            string BirtdayInput;
            Console.WriteLine("Hola bienvenido a el calculador de años!");
            Console.WriteLine("Escribe tu nombre: ");
            nameInput = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameInput}");
            Console.WriteLine("Escribe ti fecha de nacimiento en formato dd/mm/yy: ");
            BirtdayInput = Console.ReadLine();
            bool IsDateValid = DateOnly.TryParse(BirtdayInput, out dateconverted);
            if (IsDateValid == false) Console.WriteLine($"La fecha de nacimineto es invalida usted nos envio este dato erronio {BirtdayInput}");
            var person = new Person
            {
                Name = nameInput,
                Birthday = dateconverted,
                Age = DateTime.Now.Year - dateconverted.Year
            };
            Console.WriteLine($"Tú nombre: {person.Name}");
            Console.WriteLine($"Tú fecha de nacimiento: {person.Birthday}");
            Console.WriteLine($"Tú edad es: {person.Age} años!");


            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
    }
}