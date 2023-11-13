using System.Text;
using System.Xml;

namespace Lab2;

class DOMAlgorithm : IAlgorithmStrategy
{
    public List<Software> SearchingAlgorithm(SearchParameters searchParameters) 
    {
        var xmlDoc = new XmlDocument();

        xmlDoc.Load(searchParameters.InputXMLPath);

        Dictionary<string, string> queryDictionary = new Dictionary<string, string>
        {
            { "Name", searchParameters.Name },
            { "Annotation", searchParameters.Annotation },
            { "Type", searchParameters.Type },
            { "Version", searchParameters.Version },
            { "Author", searchParameters.Author },
            { "TermsOfUsage", searchParameters.TermsOfUsage },
            { "DistributiveLocation", searchParameters.DistributiveLocation }
        };

        bool isFirstTime = true;

        StringBuilder XPathQuery = new StringBuilder();

        foreach (string key in queryDictionary.Keys) 
        {
            if (queryDictionary[key] == "") 
            {
                continue;
            }
            if (!isFirstTime) 
            {
                XPathQuery.Append(" and ");
            }
            XPathQuery.Append(string.Format("(@{0} = \"{1}\")", key, queryDictionary[key]));
            isFirstTime = false;
        }

        if (XPathQuery.ToString() != "")
        {
            XPathQuery.Insert(0, "//Software [");
            XPathQuery.Append(']');
        }
        else 
        {
            XPathQuery.Append("//Software");
        }

        XmlNodeList nodes = xmlDoc.SelectNodes(XPathQuery.ToString());

        List<Software> results = new List<Software>();

        foreach (XmlNode node in nodes) 
        {
            Software software = new Software();

            XmlAttributeCollection nodeAtributes = node.Attributes;

            foreach (XmlAttribute attribute in nodeAtributes)
            {
                if (attribute.Name == "Name") { software.Name = attribute.Value; }
                else if (attribute.Name == "Annotation") { software.Annotation = attribute.Value; }
                else if (attribute.Name == "Type") { software.Type = attribute.Value; }
                else if (attribute.Name == "Version") { software.Version = attribute.Value; }
                else if (attribute.Name == "Author") { software.Author = attribute.Value; }
                else if (attribute.Name == "TermsOfUsage") { software.TermsOfUsage = attribute.Value; }
                else { software.DistributiveLocation = attribute.Value; }
            }

            results.Add(software);
        }

        return results;
    }
}