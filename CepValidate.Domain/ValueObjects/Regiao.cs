using System.Text.Json.Serialization;

namespace CepValidate.Domain.ValueObjects
{
    public class Regiao
    {
        public Regiao(string localidade, string uf)
        {
            Localidade = localidade;
            Uf = uf;
        }
        [JsonPropertyName("localidade")]
        public string Localidade { get; private set; }
        [JsonPropertyName("uf")]
        public string Uf { get; private set; }
    }
}