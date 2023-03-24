using JsonSerialization;
using Newtonsoft.Json;
using System.Text.Json;


// First Install Newtonsoft.Json fome NuGet Package

var std = new Student
{
    ID = 1,
    Name = "Hesham",
    Age = 22,
    GPA = 3.4,
    
};

// using Newton Soft json 
string Content = SerializationToJsonUsingJsonNet(std);
Console.WriteLine(Content);
Student student = DeSerializationFromJsonUsingJsonNet(Content);
Console.ReadKey();
Student DeSerializationFromJsonUsingNewTonSoft(string content)
{
    return JsonConvert.DeserializeObject<Student>(content);
}

string SerializationToJsonUsingNewTonSoft(Student std)
{
    return JsonConvert.SerializeObject(std,Formatting.Indented);
}
Student DeSerializationFromJsonUsingJsonNet(string content)
{
    Student st = System.Text.Json.JsonSerializer.Deserialize<Student>(content);
    return st;
}

string SerializationToJsonUsingJsonNet(Student std)
{
    string result = System.Text.Json.JsonSerializer.Serialize<Student>(std, new JsonSerializerOptions { WriteIndented = true });
    return result;
}
