using _452022;
using System.Text.Json;

/*
var person = new Person();
person.FirstName = "Mathew";

person.LastName = "Desjardins";
person.Id = 1;


var people = new List<Person>();

people.Add(person);
people.Add(person);


var course = new Class();

course.Title = "Server Side";
course.Major = new Major() { Abbreviation = "CSCI", Name = "Computing" };
course.Number = 2910;
course.People = people;


string jsonData = JsonSerializer.Serialize(course, new JsonSerializerOptions { WriteIndented=true});

Console.WriteLine(jsonData);
*/
string data = @"{
    ""people"":
    [
        {
            ""id"":1,
            ""firstName"":""Mathew"",
            ""lastName"":""Desjardins""
        },
        {
    ""id"":1,
            ""firstName"":""Mathew"",
            ""lastName"":""Desjardins""
        }
    ],
    ""title"":""Server Side"",
    ""number"":2910,
    ""major"":
    {
    ""abbreviation"":""CSCI"",
        ""name"":""Computing""
    }
}";

var someObject = JsonSerializer.Deserialize<Class>(data, new JsonSerializerOptions { PropertyNameCaseInsensitive = true, });

var major = someObject.Major;

Console.WriteLine(someObject.SomethingElse);
Console.WriteLine(someObject.Title);
