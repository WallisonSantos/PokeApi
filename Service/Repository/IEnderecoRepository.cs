using AspNetCore.Service.Data.ValueObjects;

namespace AspNetCore.Service.Repository
{
    public interface IEnderecoRepository
    {
        Task<EnderecoVO> FindById(string cep);
    }
}