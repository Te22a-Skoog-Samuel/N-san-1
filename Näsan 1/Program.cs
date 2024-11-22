

//  //if (6 > 3)
// {

//     Console.WriteLine("Hello, World!");
// }

// //string name = Console.ReadLine();
// //string password = Console.ReadLine();

// //if (name == "kalleanka" && password == "12345")
// {
   
//    Console.WriteLine("Welcome!");
   
//     Console.ReadLine();
// }

// //else
// {

// Console.WriteLine("Wrong username or password");

// }

// //int x = 0;

// //while (x <= 32)
// {
//     x++;

//     Console.WriteLine("Hello, World!");
// }

// //password = Console.ReadLine();

// //while (password != "password")
// {
//     Console.WriteLine("Wrong!");
//     password = Console.ReadLine();
// }



// //for (int y = 0; y<= 5; y++)
// {

// }

while (true)
{
    string number = Console.ReadLine();
    int result;
    bool sanning = int.TryParse(number, out result);

    if (result == 10)
    {
        Console.WriteLine("Mitt i prick!!");
        break;
    }
    
    if (result < 10 && sanning == true)
    {
        Console.WriteLine("Nej, gissa högre");
    }

    if (result > 10 && sanning == true)
    {
        Console.WriteLine("Nej, gissa lägre");
    }

    if (sanning == true)
    {
        Console.WriteLine("Du skrev inte ett nummer eller heltal");
    }

    Console.ReadLine();

}