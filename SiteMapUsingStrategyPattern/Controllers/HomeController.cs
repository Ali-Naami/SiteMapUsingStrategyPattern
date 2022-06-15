using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SiteMapUsingStrategyPattern.Models;
using SiteMapUsingStrategyPattern.Services;
using SiteMapUsingStrategyPattern.Services.Enums;
using SiteMapUsingStrategyPattern.Services.Implementations;

namespace SiteMapUsingStrategyPattern.Controllers;

[Route("[controller]")]
public class HomeController : Controller
{
    [Route("[action]")]
    public IActionResult GenerateSiteMap(SiteMapType siteMapType)
    {
        var mapGenerateContext = siteMapType switch
        {
            SiteMapType.News => new SiteMapGenerateContext(new NewsSiteMapGenerateService()),
            SiteMapType.Products => new SiteMapGenerateContext(new ProductSiteMapGenerateService()),
            SiteMapType.Mags => new SiteMapGenerateContext(new MagSiteMapGenerateService()),
            _ => throw new ArgumentOutOfRangeException(nameof(siteMapType), siteMapType, null)
        };

        return Json(mapGenerateContext.GenerateSiteMap());
    }
}