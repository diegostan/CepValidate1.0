namespace CepValidate.Domain.API.Urls
{
    public static class Urls
    {
        public static string ViaCepUrl(string cep)
        {
            return $"http://viacep.com.br/ws/{cep}/json/";
        }
    }
}