using CepValidate.Domain.Commands.Interfaces;
using CepValidate.Domain.Entities.BaseContext;
using CepValidate.Domain.Notifications;
using CepValidate.Domain.ValueObjects;

namespace CepValidate.Domain.Commands
{
    public class CriarEnderecamentoCommand : BaseEntity, ICommandBase
    {
        protected CriarEnderecamentoCommand() { }
        public CriarEnderecamentoCommand(string cep, string logradouro, string complemento
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
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public Regiao Regiao { get; set; }
        public int Ibge { get; set; }
        public int Gia { get; set; }
        public int DDD { get; set; }
        public int Siafi { get; set; }

        public bool Validate()
        {
            if (string.IsNullOrEmpty(Cep))
                AddNotification(new Notification(message: "O cep não pode estar em branco", "Cep"));
            
            if(Cep.Length != 8)
                AddNotification(new Notification(message: "O cep deve conter 8 digitos", "Cep"));

            if(string.IsNullOrEmpty(Logradouro))
                AddNotification(new Notification(message: "O logradouro não pode estar em branco", "Logradouro"));

            if(string.IsNullOrEmpty(Bairro))
                AddNotification(new Notification(message: "O bairro não pode estar em branco", "Bairro"));

            return (this.Notifications.Count == 0) ? true : false;
        }
    }
}