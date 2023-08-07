using AspNetCore.Service.Data.ValueObjects;
using AspNetCore.Service.Utils;

namespace AspNetCore.Service.Repository
{
    public class EnderecoRepository : IEnderecoRepository {

        private readonly HttpClient _client;

        public EnderecoRepository( HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<EnderecoVO> FindById(string cep)
        {
            var response = await _client.GetAsync($"https://viacep.com.br/ws{cep}");
            return await response.ReadContentAs<EnderecoVO>();
        }
    }
}