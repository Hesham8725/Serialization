using BinerySerialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

var std = new Student
{
    ID = 1,
    Name = "Hesham",
    Age = 22,
    GPA = 3.4
};

String BinerySerializationString = SerializationForBinery(std);
Console.WriteLine(BinerySerializationString);

Student student = DeserializationBinary(BinerySerializationString);
Console.ReadKey();
Student DeserializationBinary(string binerySerializationString)
{
    byte[] b = Convert.FromBase64String(binerySerializationString);
    using (var stream = new MemoryStream(b))
    {
        var binerySerializerFormater = new BinaryFormatter();
        stream.Seek(0, SeekOrigin.Begin);
      return  binerySerializerFormater.Deserialize(stream) as Student;
    }
}

string SerializationForBinery(Student std)
{
    //var XmlSerializer = new XmlSerializer(std.GetType());
    var binerySerializerFormater = new BinaryFormatter();
    using (var stream = new MemoryStream())
    {
        binerySerializerFormater.Serialize(stream, std);
        stream.Flush();
        stream.Position = 0;
        return Convert.ToBase64String( stream.ToArray() );
    }
}
