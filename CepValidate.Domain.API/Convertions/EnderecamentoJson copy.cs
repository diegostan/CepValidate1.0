
using CepValidate.Domain.Entities.Models;
using CepValidate.Domain.ValueObjects;

namespace CepValidate.Domain.API.Convertions
{
    public class EnderecamentoJson
    {

     

        protected EnderecamentoJson() { }


        public EnderecamentoJson(string cep, string logradouro, string complemento, string bairro, string localidade, string uf, int ibge, int gia, int dDD, int siafi)
        {
            this.Cep = cep;
            this.Logradouro = logradouro;
            this.Complemento = complemento;
            this.Bairro = bairro;
            this.Localidade = localidade;
            this.Uf = uf;
            this.Ibge = ibge;
            this.Gia = gia;
            this.DDD = dDD;
            this.Siafi = siafi;

        }
        public string Cep { get; private set; }
        public string Logradouro { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Localidade { get; private set; }
        public string Uf { get; private set; }
        public int Ibge { get; private set; }
        public int Gia { get; private set; }
        public int DDD { get; private set; }
        public int Siafi { get; private set; }

        public Enderecamento ConvertJson(EnderecamentoJson getJson)
        {
            var ret = new Enderecamento(cep: getJson.Cep, logradouro: getJson.Logradouro
            , complemento: getJson.Complemento, bairro: getJson.Bairro
            , regiao: new Regiao(localidade: getJson.Localidade, uf: getJson.Uf), ibge: getJson.Ibge, gia: getJson.Gia
            , ddd: getJson.DDD, siafi: getJson.Siafi
            );

            return ret;
        }

    }
}