using Microsoft.AspNetCore.Mvc;
using Web3.Interfaces;
using Web3.AppModels;
using Web3.Models;

namespace Web3.Controllers;

public class HomeController : Controller
{
    private readonly IProductRepository productRepository;

    public HomeController(IProductRepository productRepository)
    {
        this.productRepository = productRepository;
    }

    public async Task<IActionResult> Index()
    {
        App app = new App();
        app.Products = await this.productRepository.GetAllProducts();
        return View(app);
    }

        public IActionResult EditScreen()
    {
        App app = new App();
        return View(app);
    }

     [HttpPost, ActionName("Save")]
    public async Task<ActionResult> Save(Product NewProduct)
    {
        await this.productRepository.AddProduct(NewProduct);

        return RedirectToAction("Index");
    }

        [HttpPost, ActionName("Delete")]
    public async Task<ActionResult> Delete(int id)
    {
        await this.productRepository.DeleteProduct(id);

        return RedirectToAction("Index");
    }

}
