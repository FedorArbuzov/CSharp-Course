using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace TestSerialization
{
class Program
{
    static void Main(string[] args)
    {
 
        Order order = new Order
        {
            Products = new List<Product> {
                new Product {
                    Id =1,
                    Name = "Dummy1",
                    Quantity=1
                }
            },
            Dispatchers = new ListOfIDispatcher {
                new FileDispatcher()
                {
                    Channel = @"/home/fedor/file001.txt"
                }
            }
        };
 
        //serialize
        var xmlSerializer = new XmlSerializer(typeof(Order));
        var stringBuilder = new StringBuilder();
        var xmlTextWriter = XmlTextWriter.Create(stringBuilder,
            new XmlWriterSettings { NewLineChars = "\r\n", Indent = true });
        xmlSerializer.Serialize(xmlTextWriter, order);
        var finalXml = stringBuilder.ToString();
        
        Console.WriteLine(finalXml);
        
        //deserialize
        xmlSerializer = new XmlSerializer(typeof(Order));
        var xmlReader = XmlReader.Create(new StringReader(finalXml));
        var deserializedOrder = (Order)xmlSerializer.Deserialize(xmlReader);
        Console.WriteLine(deserializedOrder.Dispatchers[0].Channel);
        Console.WriteLine("Finish");
    }
}
 
[XmlRoot]
public class Order
{
    public List<Product> Products { get; set;}
    public ListOfIDispatcher Dispatchers { get; set; }
}
 
public class ListOfIDispatcher : List<IDispatcher>, IXmlSerializable
{
    public ListOfIDispatcher() : base() { }
 
    public System.Xml.Schema.XmlSchema GetSchema() { return null; }
 
    public void ReadXml(XmlReader reader)
    {
        reader.ReadStartElement("Dispatchers");
        while (reader.IsStartElement("IDispatcher"))
        {
            Type type = Type.GetType(reader.GetAttribute("AssemblyQualifiedName"));
            XmlSerializer serial = new XmlSerializer(type);
 
            reader.ReadStartElement("IDispatcher");
            this.Add((IDispatcher)serial.Deserialize(reader));
            reader.ReadEndElement();
        }
        reader.ReadEndElement();
    }
 
    public void WriteXml(XmlWriter writer)
    {
        foreach (IDispatcher dispatcher in this)
        {
            writer.WriteStartElement("IDispatcher");
            writer.WriteAttributeString("AssemblyQualifiedName", dispatcher.GetType().AssemblyQualifiedName);
            XmlSerializer xmlSerializer = new XmlSerializer(dispatcher.GetType());
            xmlSerializer.Serialize(writer, dispatcher);
            writer.WriteEndElement();
        }
    }
}
 
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
}
 
public interface IDispatcher
{
    string Channel { get; set; }
    void Dispatch();
}
 
public class FileDispatcher : IDispatcher
{
    public string Channel { get; set; }
 
    public void Dispatch()
    {
        //This would do something in real code
    }
}
 
public class EmailDispatcher : IDispatcher
{
    public string Channel { get; set; }
 
    public void Dispatch()
    {
        //This would do something in real code
    }
}
}