namespace HelloWorld
{
    class Program
    {

        static void Main()
        {
            /*DataTypes*/
            //nt myum = 5; /*Integer*/
            //double mydouble = 5.99; /*Double*/
            //float myfloat = 5.99f; /*Float*/
            //char mychar = 'a'; /*Character*/
            //string mystring = "Hello"; /*String*/
            //bool mybool = true;/*Boolean*/
            string nameinput;
            string birthdateinput;
            DateOnly dateConverted = new DateOnly();
            Console.WriteLine("Hola, Bienvenido al calculador de años");
            Console.WriteLine("Escribe tu nombre");
            nameinput = Console.ReadLine();
            Console.WriteLine($"Un gusto Conocerte {nameinput}");
            Console.WriteLine("Escribe tu fecha de nacimiento en formato dd/mm/yy");
            birthdateinput = Console.ReadLine();
            bool isdatevalid = DateOnly.TryParse(birthdateinput, out dateConverted);
            if (isdatevalid == false) Console.WriteLine($"La fecha que ingresaste no es valida, usted ingreso {birthdateinput}");
            var person = new person{
                Name= nameinput,
                birthdate= dateConverted,
                Age= DateTime.Now.Year - dateConverted.Year
            };
            Console.WriteLine($"Tu nombre es {person.Name}");
            Console.WriteLine($"tu edad es de {person.Age} años");
            Console.WriteLine($"tu fecha de nacimiento es {person.birthdate}");

            Console.ReadLine();

        }
    }

    public class person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly birthdate { get; set; }
    }
}