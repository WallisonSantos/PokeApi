using AspNetCore.Service.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Service.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repository;
        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }
    }
}