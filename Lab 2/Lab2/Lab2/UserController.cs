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

    public string FindInfo(string docPath, Software softwareParameters, string algorithmKey)
    {
        List<Software> softwareList = algorithms[algorithmKey].SearchingAlgorithm(docPath, softwareParameters);
        StringBuilder result = new StringBuilder();

        foreach (Software software in softwareList)
        { 
            result.AppendLine(software.ToString());
            result.AppendLine("--------------");
        }

        return result.ToString();
    }

    public void TransformToHTML(string docPath, string saveHTMLPath) 
    {
        XslCompiledTransform xslt = new XslCompiledTransform();
        xslt.Load("ToHTMLSchema.xsl");
        xslt.Transform(docPath, saveHTMLPath);
    }

    public Dictionary<string, HashSet<string>> SearchUniqueAttributesValues(string docPath) 
    {
        XmlTextReader xmlReader = new XmlTextReader(docPath);
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