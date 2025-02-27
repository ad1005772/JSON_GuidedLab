using JSON_GuidedLab;
using Newtonsoft.Json;
using System;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person
        {
            Name = "John Doe",
            Age = 30,
            Email = "johndoe@gmail.com",
            isStudent = true
        };

        string json = JsonConvert.SerializeObject(person);
        Console.WriteLine("Serialized JSON: " + json);

        Person deserializedPerson = JsonConvert.DeserializeObject<Person>(json);
        Console.WriteLine("Deserialized Person: Name - " + deserializedPerson.Name + ", Age - " + deserializedPerson.Age + ", Email - " + deserializedPerson.Email + ", Are they a student? - " + deserializedPerson.isStudent);
    }
}
