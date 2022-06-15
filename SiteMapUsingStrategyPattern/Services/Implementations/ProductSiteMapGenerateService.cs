namespace SiteMapUsingStrategyPattern.Services.Implementations;

public class ProductSiteMapGenerateService : ISiteMapGenerateService
{
    public List<string> GenerateSiteMap()
    {
        return new List<string>() { "test","test1","test3" };
    }
}