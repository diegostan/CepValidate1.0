using CepValidate.Domain.Entities.Models;
using CepValidate.Domain.Repositories.Interfaces;

namespace CepValidate.Domain.Repositories
{
    public interface IEnderecamentoRepository:IRepositoryBase
    {
        Enderecamento GetEnderecamentoByCep(string cep);
        void CriarEnderecamento(Enderecamento enderecamento);        
    }
}