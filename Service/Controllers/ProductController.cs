using Microsoft.AspNetCore.Mvc;
using AspNetCore.Service.Repository;
using AspNetCore.Service.Data.ValueObjects;

namespace AspNetCore.Service.Controller {
    
    public class ProductController : ControllerBase {

        private IProductRepository _repository;
        private IEnderecoRepository _repositoryEnder;
        public ProductController(IProductRepository repository,IEnderecoRepository repositoryEnder)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _repositoryEnder = repositoryEnder ?? throw new ArgumentNullException(nameof(repositoryEnder));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductVO>>> FindAll()
        {
            var products = await _repository.FindAll();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductVO>> FindById(long id)
        {
            var product = await _repository.FindById(id);
            if (product.Id <= 0) return NotFound();
            return Ok(product);
        }
        [HttpGet("{cep}")]
        public async Task<ActionResult<EnderecoVO>> FindByCep(string cep)
        {
            var endereco = await _repositoryEnder.FindByCep(cep);
            if (endereco.Cep == null) return NotFound();
            return Ok(endereco);
        }
        
        [HttpPost]
        public async Task<ActionResult<ProductVO>> Create([FromBody]ProductVO productVO)
        {
            if (productVO == null) return BadRequest();
            var product = await _repository.Create(productVO);
            return Ok(product);
        }        

        [HttpPut]
        public async Task<ActionResult<ProductVO>> Update([FromBody]ProductVO productVO)
        {
            if (productVO == null) return BadRequest();
            var product = await _repository.Update(productVO);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var status = await _repository.Delete(id);
            if (!status) return BadRequest();
            return Ok(status);
        }
    }
}