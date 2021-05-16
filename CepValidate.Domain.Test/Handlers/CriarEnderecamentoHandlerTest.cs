using System.Collections.Generic;
using CepValidate.Domain.Commands;
using CepValidate.Domain.Entities.Models;
using CepValidate.Domain.Handlers;
using CepValidate.Domain.Repositories;
using CepValidate.Domain.Test.Repositories;
using CepValidate.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CepValidate.Domain.Test.Handlers
{
    [TestClass]
    public class CriarEnderecamentoHandlerTest
    {
        /*red green refactory*/
        [TestMethod]
        public void HandlerValidateFail()
        {
            var command = new CriarEnderecamentoCommand(cep: "", logradouro: "", complemento: "",
            bairro: "", regiao: new Regiao(localidade: "", uf: ""), ibge: 1234, gia: 1234, ddd: 11, siafi: 0
            );

            IEnderecamentoRepository repository = new EnderecamentoRepositoryTest();
            var handle = new CriarEnderecamentoHandler(repository);
            var result = (CommandResult)handle.Handle(command);
            Assert.AreEqual(false, result.Ok);
        }

        /*red green refactory*/
        [TestMethod]
        public void HandlerValidateOk()
        {
            var command = new CriarEnderecamentoCommand(cep:"12345678", logradouro:"Rua", complemento:"",
            bairro:"Jd tal", regiao: new Regiao(localidade:"", uf:""), ibge:1234, gia:1234, ddd:11, siafi:0
            );

            IEnderecamentoRepository repository = new EnderecamentoRepositoryTest();
            var handle= new CriarEnderecamentoHandler(repository);
            var result = (CommandResult)handle.Handle(command);

            Assert.AreEqual(true, result.Ok);
        }

    }
}