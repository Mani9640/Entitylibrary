using System;
using System.Web.Mvc;
using SportsStoreDomainLibrary.Abstract;
using LoggingLibrary;
using System.Linq;

namespace SportsStoreMVCWenApp.Controllers
{


  public class ProductController : Controller
    {
    private readonly IProductRepository _productRepository;
    private readonly ILogger _logger;
    private int _pageSize;
    public ProductController(IProductRepository productRepository,ILogger logger)
    {
      _productRepository = productRepository;
      _logger = logger;
      _pageSize = 4;
    }
        public ActionResult List( int page=1)

    { 
       var productList = _productRepository.Products.OrderBy(p=>p.ProductId).Skip((page-1) *_pageSize).Take(_pageSize).ToList();

       
    //_logger.LogMessage("ProductionController", "List", TimeSpan.Zero, $"Get all Products  from repository");
    // To the view only one object can be passed  all others are string
      return View(productList);
       
      #region Withoutpaging

      //var productList = _productRepository.Products;
      //_logger.LogMessage("ProductionController", "List", TimeSpan.Zero, $"Get all Products  from repository");
      //return View(productList);
      #endregion


    }
    }
}