using System.Text;
using System.Xml;

namespace Lab2;

class DOMAlgorithm : IAlgorithmStrategy
{
    public List<Software> SearchingAlgorithm(string docPath, Software softwareQuery) 
    {
        var xmlDoc = new XmlDocument();
        xmlDoc.Load(docPath);
        Dictionary<string, string> queryDictionary = softwareQuery.ToDictionary();
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
            XPathQuery.Append(String.Format("(@{0} = \"{1}\")", key, queryDictionary[key]));
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
            results.Add(new Software(node));
        }

        return results;
    }
}