using Serialization;
using System.Xml;
using System.Xml.Serialization;

var std = new Conf_Params
{
    ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=control_ITTU;Data Source=.\\sql2008",
    TF_EXCLUDE_ID_CAL_GPA = false,
    TF_EXCLUDE_CAL_GPA_IDS_VALs = "10-19-20-12",
    FAC_LAW_SETTING = true,
    FAC_EDU_SETTING = false,
    TF_SHOW_GPA_COL = true,
    TF_SHOW_CGPA_COL = false,
    TF_RATING_ACCORDING_CGPA = true,
    TF_SHOW_PERCENTAGE_COL = false,
    TF_PASS_CONDITION = false,
    TF_SHOW_TOTAL_COL = true,
    TF_PASS_CONDITIONTOT = true,
    TF_RATING_ACCORDING_RATIO = false,
    ShowDays = false,
    FAC_LAW_SETTING_AR = false,
    RLValue = 30,
    FAC_Tamreed_SETTING_SHAPES = true
};

string XmlSerialization = XmlSerializ(std);

Console.WriteLine(XmlSerialization);

Conf_Params student = XmlDeSerializ(XmlSerialization);

Console.ReadKey();
Conf_Params XmlDeSerializ(string xmlSerialization)
{
    Conf_Params student1 = null;

    var xmlserializer = new XmlSerializer(typeof(Conf_Params));

    using (TextReader sr = new StringReader(xmlSerialization))
    {
       student1 =  xmlserializer.Deserialize(sr) as Conf_Params ;
    }
    return student1;
}

string XmlSerializ(Conf_Params std)
{
    var resual = "";
    var xmlSerializer = new XmlSerializer(std.GetType());
    using (var sw = new StringWriter())
    {
        using (var writer = XmlWriter.Create(sw,new XmlWriterSettings{Indent = true }))
        {
            xmlSerializer.Serialize(writer, std);
            resual = sw.ToString();
        }
    }
    return resual;
}