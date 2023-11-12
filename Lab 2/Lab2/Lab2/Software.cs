using System.Text;
using System.Xml;

namespace Lab2;

class Software
{
    public string Name { get; set; } = "";

    public string Annotation { get; set; } = "";

    public string Type { get; set; } = "";

    public string Version { get; set; } = "";

    public string Author { get; set; } = "";

    public string TermsOfUsage { get; set; } = "";

    public string DistributiveLocation { get; set; } = "";

    public Software() { }

    public Software(XmlNode node)
    { 
        XmlAttributeCollection nodeAtributes = node.Attributes;

        foreach (XmlAttribute attribute in nodeAtributes) 
        {
            if (attribute.Name == "Name") { Name = attribute.Value; }
            else if (attribute.Name == "Annotation") { Annotation = attribute.Value; }
            else if (attribute.Name == "Type") { Type = attribute.Value; }
            else if (attribute.Name == "Version") { Version = attribute.Value; }
            else if (attribute.Name == "Author") { Author = attribute.Value; }
            else if (attribute.Name == "TermsOfUsage") { TermsOfUsage = attribute.Value; }
            else { DistributiveLocation = attribute.Value; }
        }
    }

    public Software(Dictionary<string, string> elementInfo)
    {
        Name = elementInfo["Name"];
        Annotation = elementInfo["Annotation"];
        Type = elementInfo["Type"];
        Version = elementInfo["Version"];
        Author = elementInfo["Author"];
        TermsOfUsage = elementInfo["TermsOfUsage"];
        DistributiveLocation = elementInfo["DistributiveLocation"];
    }

    public Dictionary<string, string> ToDictionary()
    {
        Dictionary<string, string> result = new Dictionary<string, string>
        {
            { "Name", Name },
            { "Annotation", Annotation },
            { "Type", Type },
            { "Version", Version },
            { "Author", Author },
            { "TermsOfUsage", TermsOfUsage },
            { "DistributiveLocation", DistributiveLocation }
        };

        return result;
    }

    public string ToString() 
    {
        StringBuilder result = new StringBuilder();

        result.AppendLine($"Name: {Name}");
        result.AppendLine($"Annotation: {Annotation}");
        result.AppendLine($"Type: {Type}");
        result.AppendLine($"Version: {Version}");
        result.AppendLine($"Author: {Author}");
        result.AppendLine($"Terms of usage: {TermsOfUsage}");
        result.AppendLine($"Distributive location: {DistributiveLocation}");

        return result.ToString();
    }
}