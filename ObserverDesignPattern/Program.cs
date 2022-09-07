using ObserverDesignPattern;

Subject RedMI = new Subject("Red MI Mobile", 10000, "Out Of Stock");

Observer user1 = new Observer("Anurag", RedMI);

Observer user2 = new Observer("Pranaya", RedMI);

Observer user3 = new Observer("Priyanka", RedMI);

Console.WriteLine("Red MI Mobile current state : " + RedMI.getAvailability());
Console.WriteLine();

RedMI.setAvailability("Available");


Console.Read();