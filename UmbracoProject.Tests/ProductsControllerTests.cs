using NUnit.Framework;
using UmbracoProject.Controllers;

namespace UmbracoProject.Tests;

internal class Tests
{
    [Test]
    public void GetAllProducts()
    {
        var subject = new ProductsController();
        var result = subject.GetAllProducts();

        CollectionAssert.AreEquivalent(new[] {"Table", "Chair", "Desk", "Computer"}, result);
    }
    
    [TestCase(null, "Base model Monitor")]
    [TestCase(1, "Monitor model 1")]
    [TestCase(2, "Monitor model 2")]
    [TestCase(3, "Monitor model 3")]
    public void GetProduct(int? id, string message)
    {
        var subject = new ProductsController();
        var result = subject.GetProduct(id);

        Assert.That(result, Is.EqualTo(message));
    }
}