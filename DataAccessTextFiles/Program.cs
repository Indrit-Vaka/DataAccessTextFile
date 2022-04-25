
using DataAccessTextFiles;

string filePath = @"D:\DebugFiles\Test.txt";

//List<string> lines =  File.ReadAllLines(filePath).ToList();

//foreach (string line in lines)
//{
//    Console.WriteLine(line);
//}

//lines.Add("firstName,LastName,Url");

//File.WriteAllLines(filePath, lines);

//Reading 
List<Person> people = new List<Person>();

List<string> lines = File.ReadAllLines(filePath).ToList();

foreach (string line in lines)
{
    string[] entries = line.Split(',');

    var newPerson = new Person();

    newPerson.FirstName = entries[0];
    newPerson.LastName = entries[1];
    newPerson.Url = entries[2];

    people.Add(newPerson);
}

Console.WriteLine("Reading form file");
foreach (Person person in people)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}: {person.Url}");
}

//write

//adding new data
people.Add(new Person { FirstName = "Rini", LastName = "Vaka", Url = "www.text.com" });


List<string> output = new List<string>();

foreach (var person in people)
{
    output.Add($"{person.FirstName},{person.LastName},{person.Url}");
}

Console.WriteLine("Writing to text file");
File.WriteAllLines(filePath, output);

Console.WriteLine("All entries written");