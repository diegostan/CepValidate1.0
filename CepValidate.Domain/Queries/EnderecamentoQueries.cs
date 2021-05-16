using System;
using System.Linq;
using System.Linq.Expressions;
using CepValidate.Domain.Entities.Models;

namespace CepValidate.Domain.Queries
{
    public static class EnderecamentoQueries
    {
        public static Expression<Func<Enderecamento, bool>> GetEnderecamentoByCep(string cep)
        {
            return (s => s.Cep == cep);
        }        
    }
}