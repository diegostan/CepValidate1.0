using System.Linq;
using CepValidate.Domain.Entities.Models;
using CepValidate.Domain.Infra.Data;
using CepValidate.Domain.Infra.Repositories.Interfaces;
using CepValidate.Domain.Queries;
using CepValidate.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CepValidate.Domain.Infra.Repositories
{
    public class EnderecamentoRepository : IEnderecamentoRepository
    {
        readonly DataContext _repository;
        public EnderecamentoRepository(DataContext context)
        {
            _repository = context;
        }
        public void CriarEnderecamento(Enderecamento enderecamento)
        {
            _repository.Add(enderecamento);
            _repository.SaveChanges();
        }

        public Enderecamento GetEnderecamentoByCep(string cep)
        {
            var end = _repository.Enderecamentos.AsNoTracking()
            .Where(EnderecamentoQueries.GetEnderecamentoByCep(cep)).FirstOrDefault();
            return end;
        }
    }
}