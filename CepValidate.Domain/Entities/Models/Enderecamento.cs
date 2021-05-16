using CepValidate.Domain.Entities.BaseContext;
using CepValidate.Domain.ValueObjects;

namespace CepValidate.Domain.Entities.Models
{
    public class Enderecamento:BaseEntity
    {
        protected Enderecamento(){}
        public Enderecamento(string cep, string logradouro, string complemento
        , string bairro, Regiao regiao, int ibge, int gia, int ddd, int siafi)
        {
            Cep = cep;
            Logradouro = logradouro;
            Complemento = complemento;
            Bairro = bairro;
            Regiao = regiao;
            Ibge = ibge;
            Gia = gia;
            DDD = ddd;
            Siafi = siafi;
        }

        public string Cep{get;private set;}
        public string Logradouro{get;private set;}
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public Regiao Regiao{get;private set;}
        public int Ibge { get; private set; }
        public int Gia { get; private set; }
        public int DDD { get; private set; }
        public int Siafi {get; private set;}
    }
}