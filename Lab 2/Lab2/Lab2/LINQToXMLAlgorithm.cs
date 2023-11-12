using System.Xml.Linq;

namespace Lab2;

class LINQToXMLAlgorithm : IAlgorithmStrategy
{
    public List<Software> SearchingAlgorithm(string docPath, Software softwareQuery) 
    {
        var doc = XDocument.Load(docPath);
        List<Software> result = new List<Software>();

        var resultNodes = (from software in doc.Descendants("Software")
                     where ((softwareQuery.Name == "" || softwareQuery.Name == software.Attribute("Name").Value)
                     && (softwareQuery.Annotation == "" || softwareQuery.Annotation == software.Attribute("Annotation").Value)
                     && (softwareQuery.Type == "" || softwareQuery.Type == software.Attribute("Type").Value)
                     && (softwareQuery.Version == "" || softwareQuery.Version == software.Attribute("Version").Value)
                     && (softwareQuery.Author == "" || softwareQuery.Author == software.Attribute("Author").Value)
                     && (softwareQuery.TermsOfUsage == "" || softwareQuery.TermsOfUsage == software.Attribute("TermsOfUsage").Value
                     && (softwareQuery.DistributiveLocation == "" || softwareQuery.DistributiveLocation == software.Attribute("DistributiveLocation").Value)))
                     select software).ToList();

        //Можливо, можна використати більш гнучкий підхід

        foreach (XElement softwareNode in resultNodes) 
        {
            Software software = new Software();
            software.Name = softwareNode.Attribute("Name").Value;
            software.Annotation = softwareNode.Attribute("Annotation").Value;
            software.Type = softwareNode.Attribute("Type").Value;
            software.Version = softwareNode.Attribute("Version").Value;
            software.Author = softwareNode.Attribute("Author").Value;
            software.TermsOfUsage = softwareNode.Attribute("TermsOfUsage").Value;
            software.DistributiveLocation = softwareNode.Attribute("DistributiveLocation").Value;
            result.Add(software);
        }

        return result;
    }
}