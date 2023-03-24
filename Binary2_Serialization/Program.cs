using Binary2_Serialization;
using System.Runtime.Serialization.Formatters.Binary;

var std = new Student
{
    ID = 1,
    Name = "Hesham",
    Age = 22,
    GPA = 3
};

FunSerialize(std);
Student x = FunDeSerialize();
Console.ReadKey();
void FunSerialize(Student std)
{
    BinaryFormatter binaryFormatter = new BinaryFormatter();
    using(FileStream file = new FileStream("sasa.txt" , FileMode.Create))
    {
        binaryFormatter.Serialize(file, std);
    }
}

Student FunDeSerialize()
{
    Student student;
    BinaryFormatter binaryFormatter = new BinaryFormatter();
    using (FileStream file = new FileStream("sasa.txt", FileMode.Open))
    {
        student = binaryFormatter.Deserialize(file) as Student;
    }
    return student;
}