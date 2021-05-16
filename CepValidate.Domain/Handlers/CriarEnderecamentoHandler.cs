using System;
using CepValidate.Domain.Commands;
using CepValidate.Domain.Commands.Interfaces;
using CepValidate.Domain.Entities.Models;
using CepValidate.Domain.Handlers.Interfaces;
using CepValidate.Domain.Repositories;

namespace CepValidate.Domain.Handlers
{
    public class CriarEnderecamentoHandler : IHandlerBase<CriarEnderecamentoCommand>
    {
        readonly IEnderecamentoRepository _repository;
        public CriarEnderecamentoHandler(IEnderecamentoRepository repository)
        {
            _repository = repository;
        }
        public ICommandBase Handle(CriarEnderecamentoCommand command)
        {
            if(!command.Validate())
                return new CommandResult(ok:false, propertyName:"CriarEnderecamentoCommand"
                , message: "O comando não passou na validação", command.Notifications);

            var end = new Enderecamento(cep:command.Cep, logradouro:command.Logradouro
            ,complemento:command.Complemento, bairro: command.Bairro,regiao:command.Regiao
            ,ibge:command.Ibge,gia:command.Gia,ddd:command.DDD,siafi:command.Siafi);
            
            _repository.CriarEnderecamento(end);
            
            return new CommandResult(ok:true,"CriarEnderecamentoCommand"
            , "Endereçamento criado com sucesso", null);
        }
    }
}