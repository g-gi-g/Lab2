using System.Xml.Linq;

namespace Lab2;

class LINQToXMLAlgorithm : IAlgorithmStrategy
{
    public List<Software> SearchingAlgorithm(SearchParameters searchParameters) 
    {
        var doc = XDocument.Load(searchParameters.InputXMLPath);

        List<Software> result = new List<Software>();

        var resultNodes = (from softwareNode in doc.Descendants("Software")
                     where ((searchParameters.Name == "" || searchParameters.Name == softwareNode.Attribute("Name").Value)
                     && (searchParameters.Annotation == "" || searchParameters.Annotation == softwareNode.Attribute("Annotation").Value)
                     && (searchParameters.Type == "" || searchParameters.Type == softwareNode.Attribute("Type").Value)
                     && (searchParameters.Version == "" || searchParameters.Version == softwareNode.Attribute("Version").Value)
                     && (searchParameters.Author == "" || searchParameters.Author == softwareNode.Attribute("Author").Value)
                     && (searchParameters.TermsOfUsage == "" || searchParameters.TermsOfUsage == softwareNode.Attribute("TermsOfUsage").Value
                     && (searchParameters.DistributiveLocation == "" || searchParameters.DistributiveLocation == softwareNode.Attribute("DistributiveLocation").Value)))
                     select softwareNode).ToList();

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