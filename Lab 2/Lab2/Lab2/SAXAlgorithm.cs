using System.Xml;

namespace Lab2;

class SAXAlgorithm : IAlgorithmStrategy
{
    public List<Software> SearchingAlgorithm(SearchParameters searchParameters) 
    { 
        var xmlReader = new XmlTextReader(searchParameters.InputXMLPath);

        List<Software> result = new List<Software>();

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

        while (xmlReader.Read()) 
        {
            try
            {
                if (xmlReader.NodeType == XmlNodeType.Element
                && xmlReader.HasAttributes)
                {
                    Software software = new Software();

                    foreach (string key in queryDictionary.Keys)
                    {
                        xmlReader.MoveToNextAttribute();

                        if (queryDictionary[key] != ""
                            && queryDictionary[key] != xmlReader.Value)
                        {
                            throw new Exception("Element doesn't match requirements");
                        }

                        var property = software.GetType().GetProperty(xmlReader.Name);

                        property.SetValue(software, xmlReader.Value);  
                    }
                    result.Add(software);
                }
            }

            catch (Exception) {}
        }

        return result;
    }
}