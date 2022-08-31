//Console.WriteLine("Hej NTI");
//Console.WriteLine("Hej nörd");

string name;
string favdrink;
string favfood;
string place;



Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("What is your name?");

Console.BackgroundColor = ConsoleColor.Red;
name = Console.ReadLine();

if (name == "fuck you"){
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.WriteLine("Woah man, calm down!");
}

if (name == "fuck you" == false){
    

if (name == "Hampus"){

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"{name}, What a pretty name, ey?");
Console.WriteLine($"So! Tell me {name}, what is your favorite drink?");

Console.BackgroundColor = ConsoleColor.Red;
favdrink = Console.ReadLine();

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("Well that's tasty");
Console.WriteLine("Anyway, what is your favorite food?");

Console.BackgroundColor = ConsoleColor.Red;
favfood = Console.ReadLine();

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"sorry to say {name}, but you have amazing tastebuds");
Console.WriteLine("Now, name any place");

Console.BackgroundColor = ConsoleColor.Red;
place = Console.ReadLine();

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"{name} sat at {place} and had a meal, said meal was made up of {favfood} and {favdrink}, now, unfortunate for {name}, the {favfood} was stolen by a bird. {name} was so angry, they got a rifle and shot the bird, and exchanged their {favfood} for a roasted bird insted!");

Console.ReadLine();
}

if (name == "Hampus" == false){
//surname = "Eriksson";
//name = "HAmpus";

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"{name}, Oh, okay?");
Console.WriteLine($"So! Tell me {name}, what is your favorite drink?");

Console.BackgroundColor = ConsoleColor.Red;
favdrink = Console.ReadLine();

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("Well that's nasty");
Console.WriteLine("Anyway, what is your favorite food?");

Console.BackgroundColor = ConsoleColor.Red;
favfood = Console.ReadLine();

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"sorry to say {name}, but you have Horrible tastebuds");
Console.WriteLine("Now, name any place");

Console.BackgroundColor = ConsoleColor.Red;
place = Console.ReadLine();

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"{name} sat at {place} and had a meal, said meal was made up of {favfood} and {favdrink}, now, unfortunate for {name}, the {favfood} was stolen by a bird. {name} was so angry, they got a rifle and shot the bird, and exchanged their {favfood} for a roasted bird insted!");

Console.ReadLine();
}
}
Console.ReadLine();