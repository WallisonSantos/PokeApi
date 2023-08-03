using AutoMapper;
using AspNetCore.Service.Model;
using Microsoft.EntityFrameworkCore;
using AspNetCore.Service.Model.Context;
using AspNetCore.Service.Data.ValueObjects;

namespace AspNetCore.Service.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;
        public ProductRepository( MySQLContext context , IMapper mapper )
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductVO>> FindAll()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductVO>>(products);
        }

        public async Task<ProductVO> FindById(long id)
        {
            Product product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync() ?? throw new InvalidOperationException(nameof(id));
            return _mapper.Map<ProductVO>(product);
        }
        public async Task<ProductVO> Create(ProductVO productVO)
        {
            Product product = _mapper.Map<Product>(productVO);
            _context.Products.Add(product);
            return _mapper.Map<ProductVO>(product);
        }
        public async Task<ProductVO> Update(ProductVO productVO)
        {
            Product product = _mapper.Map<Product>(productVO);
            _context.Products.Update(product);
            return _mapper.Map<ProductVO>(product);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Product product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync() ?? throw new InvalidOperationException(nameof(id));
                if(product == null) return false;
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception) 
            { 
                return false; 
            }
        }
    }
}