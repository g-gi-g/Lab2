using System.Text;
using System.Xml;
using System.Xml.Xsl;

namespace Lab2;

class UserController
{
    private Dictionary<string, IAlgorithmStrategy> algorithms;

    public UserController() 
    {
        algorithms = new Dictionary<string, IAlgorithmStrategy>()
        {
            { "SAX", new SAXAlgorithm() },
            { "DOM", new DOMAlgorithm() },
            { "LINQ", new LINQToXMLAlgorithm() }
        };
    }

    public string FindInfo(SearchParameters searchParameters, string algorithmKey)
    {
        List<Software> softwareList = algorithms[algorithmKey].SearchingAlgorithm(searchParameters);

        StringBuilder result = new StringBuilder();

        foreach (Software software in softwareList)
        {
            StringBuilder softwareAsString = new StringBuilder();

            softwareAsString.AppendLine($"Name: {software.Name}");
            softwareAsString.AppendLine($"Annotation: {software.Annotation}");
            softwareAsString.AppendLine($"Type: {software.Type}");
            softwareAsString.AppendLine($"Version: {software.Version}");
            softwareAsString.AppendLine($"Author: {software.Author}");
            softwareAsString.AppendLine($"Terms of usage: {software.TermsOfUsage}");
            softwareAsString.AppendLine($"Distributive location: {software.DistributiveLocation}");

            result.AppendLine(softwareAsString.ToString());

            result.AppendLine("--------------");
        }

        return result.ToString();
    }

    public void TransformToHTML(string inputXMLPath, string outputHTMLPath) 
    {
        XslCompiledTransform xslt = new XslCompiledTransform();

        xslt.Load("ToHTMLSchema.xsl");

        xslt.Transform(inputXMLPath, outputHTMLPath);
    }

    public Dictionary<string, HashSet<string>> SearchUniqueAttributesValues(string inputXMLPath) 
    {
        XmlTextReader xmlReader = new XmlTextReader(inputXMLPath);

        Dictionary<string, HashSet<string>> uniqueAttributesValues = new Dictionary<string, HashSet<string>>()
        {
            { "Name", new HashSet<string>() },
            { "Annotation", new HashSet<string>() },
            { "Type", new HashSet<string>() },
            { "Version", new HashSet<string>() },
            { "Author", new HashSet<string>() },
            { "TermsOfUsage", new HashSet<string>() },
            { "DistributiveLocation", new HashSet<string>() }
        };

        while (xmlReader.Read()) 
        {
            if (xmlReader.HasAttributes &&
                xmlReader.NodeType == XmlNodeType.Element)
            {
                while (xmlReader.MoveToNextAttribute())
                {
                    uniqueAttributesValues[xmlReader.Name].Add(xmlReader.Value);
                }
            }
        }

        return uniqueAttributesValues;
    }
}