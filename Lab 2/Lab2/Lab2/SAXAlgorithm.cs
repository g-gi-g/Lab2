using System.Xml;

namespace Lab2;

class SAXAlgorithm : IAlgorithmStrategy
{
    public List<Software> SearchingAlgorithm(string docPath, Software softwareQuery) 
    { 
        var xmlReader = new XmlTextReader(docPath);
        List<Software> result = new List<Software>();
        Dictionary<string, string> queryDictionary = softwareQuery.ToDictionary();
        Dictionary<string, string> elementInfo = new Dictionary<string, string>();
        bool IsFirstIterationThroughArguments = true;

        while (xmlReader.Read()) 
        {
            try
            {
                if (xmlReader.NodeType == XmlNodeType.Element
                && xmlReader.HasAttributes)
                {
                    //Перевірка на задані умови
                    foreach (string key in queryDictionary.Keys)
                    {
                        while (xmlReader.MoveToNextAttribute())
                        {
                            if (key == xmlReader.Name
                                && queryDictionary[key] != ""
                                && queryDictionary[key] != xmlReader.Value)
                            {
                                throw new Exception("Element doesn't match requirements");
                            }

                            if (IsFirstIterationThroughArguments) 
                            {
                                elementInfo.Add(xmlReader.Name, xmlReader.Value);
                            }    
                        }
                        xmlReader.MoveToAttribute("Name");
                        IsFirstIterationThroughArguments = false;
                    }
                    result.Add(new Software(elementInfo));
                    elementInfo.Clear();
                    IsFirstIterationThroughArguments = true;
                }
            }

            catch (Exception)
            {
                elementInfo.Clear();
                IsFirstIterationThroughArguments = true;
            }
        }
        return result;
    }
}