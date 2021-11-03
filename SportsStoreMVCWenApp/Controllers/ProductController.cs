using System;
using System.Web.Mvc;
using SportsStoreDomainLibrary.Abstract;
using LoggingLibrary;

namespace SportsStoreMVCWenApp.Controllers
{


  public class ProductController : Controller
    {
    private readonly IProductRepository _productRepository;
    private readonly ILogger _logger;
    public ProductController(IProductRepository productRepository,ILogger logger)
    {
      _productRepository = productRepository;
      _logger = logger;
    }
        public ActionResult List()
        {
      
          var productList = _productRepository.Products;
         _logger.LogMessage("ProductionController", "List", TimeSpan.Zero, $"Get all Products  from repository");

            return View(productList);
        }
    }
}