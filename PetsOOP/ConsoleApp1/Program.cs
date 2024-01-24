using ClassLibrary1;

string input = "";

while (input != "4")
{
    Console.WriteLine("Welcome to the Pet Store");
    Console.WriteLine("1. Add a new pet");
    Console.WriteLine("2. List all pets");
    Console.WriteLine("3. Have 2 pets meet");
    Console.WriteLine("4. Exit");
        input = Console.ReadLine();
    switch (input)
    {
        case "1":
            Console.WriteLine("what is the name of the new pet?");
            string petName = Console.ReadLine();
            Console.WriteLine("1. Add a new cat");
            Console.WriteLine("1. Add a new chimp");
            Console.WriteLine("1. Add a new turtle");
            string input2 = Console.ReadLine();
            switch (input2)
            { 
                case "1":
                    Cat newcat = new Cat(petName);
                    break;
                case "2":
                    Chimpanzee newChimp = new Chimpanzee(petName);
                    break;
                case "3":
                    Turtle newTurtle = new Turtle(petName);
                    break;
            }
            break; 
        case "2":
            break;
        case "3":
            break;
        case "4":
            break;
        default:
            break;
    }
}

