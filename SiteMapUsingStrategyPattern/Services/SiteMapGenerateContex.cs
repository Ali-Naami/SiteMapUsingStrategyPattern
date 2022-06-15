namespace SiteMapUsingStrategyPattern.Services;

public class SiteMapGenerateContext
{
    private  ISiteMapGenerateService _siteMapGenerateService;

    public SiteMapGenerateContext(ISiteMapGenerateService siteMapGenerateService)
    {
        _siteMapGenerateService = siteMapGenerateService;
    }

    public void SetSiteMapGenerate(ISiteMapGenerateService siteMapGenerateService)
    {
        _siteMapGenerateService = siteMapGenerateService;
        
    }
    public List<string> GenerateSiteMap()
    {
        var siteMapList = _siteMapGenerateService.GenerateSiteMap();
        return siteMapList;
    }
}