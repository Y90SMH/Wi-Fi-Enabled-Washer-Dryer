using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.Common.Controllers;

namespace UmbracoProject.Controllers;

public class ProductsController : UmbracoApiController
{
    public IEnumerable<string> GetAllProducts()
    {
        return new[] {"Table", "Chair", "Desk", "Computer"};
    }

    [Route("product/{id:int?}")]
    public string GetProduct(int? id)
    {
        return id is not null
            ? $"Monitor model {id}"
            : "Base model Monitor";
    }
}